import React, { useState, useEffect } from "react";
import axios from "axios";
import MapChart, { type RecordAgg } from "./MapChart";
import "./CovidMapTabs.css";

type DataType =
  | "confirmed"
  | "deaths"
  | "recovered"
  | "active"
  | "daily_reports";

const CovidMapTabs: React.FC = () => {
  const [type, setType] = useState<DataType>("confirmed");
  const [allData, setAllData] = useState<Record<string, RecordAgg[]>>({
    confirmed: [],
    deaths: [],
    recovered: [],
    active: [],
    daily_reports: [],
  });
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchAllData = async () => {
      try {
        setLoading(true);
        const lastDateResConfirms = await axios.get(
          "http://localhost:5230/odata/Confirms?$apply=aggregate(Date with max as LastDate)"
        );
        const lastDateResDeaths = await axios.get(
          "http://localhost:5230/odata/Deaths?$apply=aggregate(Date with max as LastDate)"
        );
        const lastDateResRecovereds = await axios.get(
          "http://localhost:5230/odata/Recovereds?$apply=aggregate(Date with max as LastDate)"
        );

        const lastDateConfirms = lastDateResConfirms.data?.[0]?.LastDate;
        const lastDateDeaths = lastDateResDeaths.data?.[0]?.LastDate;
        const lastDateRecovereds = lastDateResRecovereds.data?.[0]?.LastDate;

        const endpoints: Record<DataType, string> = {
          confirmed: `http://localhost:5230/odata/Confirms?$apply=filter(Date eq ${lastDateConfirms})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`,
          deaths: `http://localhost:5230/odata/Deaths?$apply=filter(Date eq ${lastDateDeaths})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`,
          recovered: `http://localhost:5230/odata/Recovereds?$apply=filter(Date eq ${lastDateRecovereds})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`,
          active: "", // sẽ tính tay
          daily_reports: "",
        };

        const results = await Promise.all(
          Object.entries(endpoints).map(async ([key, url]) => {
            if (!url) return [key, []] as [string, RecordAgg[]];
            const res = await axios.get(url);
            const data: RecordAgg[] = Array.isArray(res.data.value)
              ? res.data.value
              : res.data;
            return [key, data] as [string, RecordAgg[]];
          })
        );

        const confirmed = results.find(([k]) => k === "confirmed")?.[1] || [];
        const deaths = results.find(([k]) => k === "deaths")?.[1] || [];

        // ✅ Active = Confirmed - Deaths
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
      <div className="loading-container">
        <div className="spinner"></div>
        <span>Đang tải dữ liệu...</span>
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
      case "active":
        return (
          <MapChart
            data={allData.active}
            title="COVID-19 Active Cases"
            colorbarTitle="Active"
          />
        );
    }
  };

  const tabConfig: Record<DataType, { label: string; emoji: string }> = {
    confirmed: { label: "Confirmed", emoji: "🦠" },
    deaths: { label: "Deaths", emoji: "⚰️" },
    recovered: { label: "Recovered", emoji: "💚" },
    active: { label: "Active", emoji: "🔵" },
    daily_reports: { label: "Daily Reports", emoji: "📊" },
  };

  return (
    <div className="covid-container">
      <h2 className="covid-header">🌍 COVID-19 Global Overview</h2>

      <div className="tab-wrapper">
        <nav className="tab-list">
          {(Object.keys(tabConfig) as DataType[]).map((t) => (
            <button
              key={t}
              onClick={() => setType(t)}
              className={`tab-item ${type === t ? "active" : ""}`}
            >
              <span className="emoji">{tabConfig[t].emoji}</span>
              {tabConfig[t].label}
            </button>
          ))}
        </nav>
      </div>

      <div className="map-wrapper">{renderMap()}</div>
    </div>
  );
};

export default CovidMapTabs;
