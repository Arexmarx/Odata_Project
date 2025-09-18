import React, { useState, useEffect } from "react";
import axios from "axios";
import MapChart, { type RecordAgg } from "./MapChart";

type DataType = "confirmed" | "deaths" | "recovered" | "daily_reports";

const CovidMapTabs: React.FC = () => {
  const [type, setType] = useState<DataType>("confirmed");
  const [allData, setAllData] = useState<Record<string, RecordAgg[]>>({
    confirmed: [],
    deaths: [],
    recovered: [],
    daily_reports: [],
  });
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchAllData = async () => {
      try {
        setLoading(true);
        const lastDateRes = await axios.get(
          "http://localhost:5230/odata/Confirms?$apply=aggregate(Date with max as LastDate)"
        );
        const lastDate = lastDateRes.data?.[0]?.LastDate;
        if (!lastDate) throw new Error("Không lấy được LastDate");

        const endpoints: Record<DataType, string> = {
          confirmed: `http://localhost:5230/odata/Confirms?$apply=filter(Date eq ${lastDate})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`,
          deaths: `http://localhost:5230/odata/Deaths?$apply=filter(Date eq ${lastDate})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`,
          recovered: `http://localhost:5230/odata/Recovereds?$apply=filter(Date eq ${lastDate})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`,
          daily_reports: "",
        };

        // gọi API
        const results = await Promise.all(
          Object.entries(endpoints).map(async ([key, url]) => {
            if (!url) return [key, []] as [string, RecordAgg[]];
            const res = await axios.get(url);

            const data: RecordAgg[] = Array.isArray(res.data) ? res.data : [];

            return [key, data] as [string, RecordAgg[]];
          })
        );

        const confirmed = results.find(([k]) => k === "confirmed")?.[1] || [];
        const deaths = results.find(([k]) => k === "deaths")?.[1] || [];

        // tính Active = Confirmed - Deaths
        const active: RecordAgg[] = confirmed.map((c) => {
          const d = deaths.find((x) => x.CountryRegion === c.CountryRegion);

          const confirmedVal = c.LastValue ?? 0;
          const deathsVal = d?.LastValue ?? 0;

          return {
            CountryRegion: c.CountryRegion,
            LastDate: c.LastDate,
            LastValue: confirmedVal - deathsVal,
          };
        });

        results.push(["active", active]);

        setAllData(Object.fromEntries(results));
        setLoading(false);
      } catch (err) {
        console.error(err);
        setLoading(false);
      }
    };

    fetchAllData();
  }, []);

  if (loading)
    return (
      <div className="flex items-center justify-center h-64 text-blue-600 font-semibold animate-pulse">
        Loading data...
      </div>
    );

  const renderMap = () => {
    switch (type) {
      case "confirmed":
        return (
          <MapChart
            data={allData.confirmed}
            title="COVID-19 Confirmed Cases"
            colorbarTitle="Confirmed"
          />
        );
      case "deaths":
        return (
          <MapChart
            data={allData.deaths}
            title="COVID-19 Deaths"
            colorbarTitle="Deaths"
          />
        );
      case "recovered":
        return (
          <MapChart
            data={allData.recovered}
            title="COVID-19 Recovered"
            colorbarTitle="Recovered"
          />
        );
    }
  };

  const tabConfig: Record<DataType, { label: string; emoji: string }> = {
    confirmed: { label: "Confirmed", emoji: "🦠" },
    deaths: { label: "Deaths", emoji: "⚰️" },
    recovered: { label: "Recovered", emoji: "💚" },
    daily_reports: { label: "Daily Reports", emoji: "📊" },
  };

  return (
    <>
      {/* Header */}
      <h2 className="text-2xl font-bold text-center mb-6 text-gray-800">
        🌍 COVID-19 Global Overview
      </h2>

      {/* Tabs */}
      <div className="flex justify-center flex-wrap gap-3 mb-6">
        {(Object.keys(tabConfig) as DataType[]).map((t) => (
          <button
            key={t}
            className={`flex items-center gap-2 px-5 py-2 rounded-full font-medium transition-all ${
              type === t
                ? "bg-blue-600 text-white shadow-md scale-105"
                : "bg-gray-100 text-gray-700 hover:bg-gray-200"
            }`}
            onClick={() => setType(t)}
          >
            <span>{tabConfig[t].emoji}</span>
            {tabConfig[t].label}
          </button>
        ))}
      </div>

      {/* Map */}
      <div className="rounded-xl overflow-hidden border border-gray-200 shadow-lg bg-white">
        {renderMap()}
      </div>
    </>
  );
};

export default CovidMapTabs;
