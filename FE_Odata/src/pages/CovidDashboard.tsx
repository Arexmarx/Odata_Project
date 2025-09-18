import { useState, useEffect } from "react";
import { ResponsiveContainer, Treemap } from "recharts";
import "./CovidDashboard.css";
import axios from "axios";

interface CountryData {
  country: string;
  value: number;
  percentage: number;
  color: string;
}

interface TreeMapNode {
  name: string;
  value: number;
  percentage: number;
  fill: string;
}

const CovidDashboard = () => {
  const [activeTab, setActiveTab] = useState("Confirmed");
  const [worldData, setWorldData] = useState<CountryData[]>([]);
  const [treemapData, setTreemapData] = useState<TreeMapNode[]>([]);
  const [loading, setLoading] = useState(true);

  const colors = [
    "#3b82f6",
    "#ef4444",
    "#10b981",
    "#8b5cf6",
    "#f97316",
    "#f472b6",
    "#22d3ee",
    "#84cc16",
  ];

  // Fetch OData
  const fetchODataData = async () => {
    try {
      setLoading(true);

      const apiMap: Record<string, string> = {
        Confirmed: "Confirms",
        Active: "Recovereds",
        Recovered: "Recovereds",
        Deaths: "Deaths",
        "Daily Increase": "DailyReports",
      };

      const endpoint = apiMap[activeTab] || "Confirms";

      let url = "";

      if (activeTab === "Daily Increase") {
        url = `http://localhost:5230/odata/DailyReports?$apply=filter(Date eq max(Date))/groupby((CountryRegion), aggregate(Confirmed with sum as LastConfirmed))`;
      } else {
        url = `http://localhost:5230/odata/${endpoint}?$apply=groupby((CountryRegion),aggregate(Date with max as LastDate,Value with max as LastValue))`;
      }

      const res = await axios.get(url);
      const json = res.data;
      console.log("Raw OData Response:", json); // 👈 debug response

      const arr: CountryData[] = (json.value ?? []).map(
        (item: any, i: number) => ({
          country: item.CountryRegion ?? "Unknown",
          value:
            activeTab === "Daily Increase"
              ? item.LastConfirmed ?? 0
              : item.LastValue ?? 0,
          percentage: 0,
          color: colors[i % colors.length],
        })
      );

      const total = arr.reduce((sum, d) => sum + (d.value || 0), 0);

      arr.forEach((d) => {
        d.percentage = total > 0 ? +((d.value / total) * 100).toFixed(1) : 0;
      });

      arr.sort((a, b) => b.value - a.value);

      const tmap: TreeMapNode[] = arr.map((d) => ({
        name: d.country,
        value: d.value,
        percentage: d.percentage,
        fill: d.color,
      }));

      setWorldData(arr);
      setTreemapData(tmap);
    } catch (error) {
      console.error("Error fetching OData:", error);
      setWorldData([]);
      setTreemapData([]);
    } finally {
      setLoading(false);
    }
  };

  useEffect(() => {
    fetchODataData();
  }, [activeTab]);

  const tabs = ["Confirmed", "Active", "Recovered", "Deaths", "Daily Increase"];

  const formatNumber = (num?: number | null) => {
    if (num == null || isNaN(num as number)) return "0";
    if (num >= 1_000_000) return (num / 1_000_000).toFixed(1) + "M";
    if (num >= 1_000) return (num / 1_000).toFixed(1) + "K";
    return num.toString();
  };

  const CustomTreemapContent = (props: any) => {
    const { x, y, width, height, name, value, percentage, fill } = props;
    if (width < 50 || height < 30) return null;
    return (
      <g>
        <rect
          x={x}
          y={y}
          width={width}
          height={height}
          fill={fill}
          stroke="#fff"
        />
        {width > 100 && height > 60 && (
          <>
            <text
              x={x + width / 2}
              y={y + height / 2 - 10}
              textAnchor="middle"
              fill="white"
              fontSize={12}
              fontWeight="bold"
            >
              {name}
            </text>
            <text
              x={x + width / 2}
              y={y + height / 2 + 5}
              textAnchor="middle"
              fill="white"
              fontSize={11}
            >
              {formatNumber(value)}
            </text>
            <text
              x={x + width / 2}
              y={y + height / 2 + 20}
              textAnchor="middle"
              fill="white"
              fontSize={10}
            >
              {percentage}%
            </text>
          </>
        )}
      </g>
    );
  };

  return (
    <div className="dashboard">
      {/* Tabs */}
      <div className="tabs">
        {tabs.map((tab) => (
          <button
            key={tab}
            onClick={() => setActiveTab(tab)}
            className={`tab-button ${activeTab === tab ? "active" : ""}`}
          >
            {tab}
          </button>
        ))}
      </div>

      {/* Treemap */}
      <div className="card">
        <h3>Treemap of Countries</h3>
        <p className="subtitle">
          The Treemap shows the number of cases in different countries and their
          percentage worldwide
        </p>

        <div className="treemap-container">
          {loading ? (
            <div className="loading">Loading...</div>
          ) : (
            <ResponsiveContainer width="100%" height="100%">
              <Treemap
                data={treemapData}
                dataKey="value"
                strokeWidth={2}
                content={<CustomTreemapContent />}
              />
            </ResponsiveContainer>
          )}
        </div>
      </div>

      {/* Stats Cards */}
      <div className="stats-grid">
        {worldData.slice(0, 4).map((c) => (
          <div key={c.country} className="stat-card">
            <div>
              <p className="country">{c.country}</p>
              <p className="value">{formatNumber(c.value)}</p>
              <p className="percentage">{c.percentage}% of total</p>
            </div>
            <div className="circle" style={{ backgroundColor: c.color }}></div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default CovidDashboard;
