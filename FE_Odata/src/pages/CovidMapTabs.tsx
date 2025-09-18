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
        const endpoints: Record<DataType, string> = {
          confirmed:
            "http://localhost:5230/odata/Confirms?$apply=groupby((CountryRegion),aggregate(Date with max as LastDate,Value with max as LastValue))",
          deaths:
            "http://localhost:5230/odata/Deaths?$apply=groupby((CountryRegion),aggregate(Date with max as LastDate,Value with max as LastValue))",
          recovered:
            "http://localhost:5230/odata/Recovereds?$apply=groupby((CountryRegion),aggregate(Date with max as LastDate,Value with max as LastValue))",
          daily_reports: "",
        };

        // gọi API
        const results = await Promise.all(
          Object.entries(endpoints).map(async ([key, url]) => {
            if (!url) return [key, []] as [string, RecordAgg[]];
            const res = await axios.get(url);
            // OData thường trả về { value: [...] }
            const raw = res.data.value ?? res.data;
            const data: RecordAgg[] = Array.isArray(raw) ? raw : [];
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

  if (loading) return <div className="text-center p-6">Loading data...</div>;

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

  return (
    <div className="w-full max-w-6xl mx-auto p-6 bg-white shadow-lg rounded-xl">
      <div className="flex justify-center gap-4 mb-4">
        {(
          ["confirmed", "deaths", "recovered", "daily_reports"] as DataType[]
        ).map((t) => (
          <button
            key={t}
            className={`px-4 py-2 rounded ${
              type === t
                ? "bg-blue-600 text-white"
                : "bg-gray-200 text-gray-800"
            }`}
            onClick={() => setType(t)}
          >
            {t.replace("_", " ").toUpperCase()}
          </button>
        ))}
      </div>

      <div className="rounded-lg overflow-hidden border border-gray-200">
        {renderMap()}
      </div>
    </div>
  );
};

export default CovidMapTabs;
