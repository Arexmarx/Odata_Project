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

      // Map tab -> API endpoint
      const apiMap: Record<string, string> = {
        Confirmed: "Confirms",
        Active: "Recovereds", // nếu bạn có bảng Active riêng thì chỉnh lại
        Recovered: "Recovereds",
        Deaths: "Deaths",
        "Daily Increase": "DailyReports",
      };

      const endpoint = apiMap[activeTab] || "Confirms";
      const res = await axios.get(`http://localhost:5230/odata/${endpoint}`);
      const json = res.data;

      const grouped: Record<
        string,
        { country: string; value: number; date?: Date }
      > = {};

      json.value.forEach((item: any) => {
        const country = item.CountryRegion;
        let value = 0;

        if (activeTab === "Daily Increase") {
          // Dùng cột Confirmed trong DailyReports
          value = item.Confirmed ?? 0;
        } else {
          value = item.Value ?? 0;
        }

        const date = item.Date ? new Date(item.Date) : null;

        if (
          !grouped[country] ||
          (date &&
            grouped[country].date &&
            grouped[country].date < date)
        ) {
          grouped[country] = { country, value, date: date ?? undefined };
        }
      });

      const arr = Object.values(grouped).map((d, i) => ({
        country: d.country,
        value: d.value,
        percentage: 0,
        color: colors[i % colors.length],
      }));

      const total = arr.reduce((sum, d) => sum + d.value, 0);
      arr.forEach(
        (d) =>
          (d.percentage = ((d.value / total) * 100).toFixed(1) as any)
      );

      arr.sort((a, b) => b.value - a.value);

      const tmap = arr.map((d) => ({
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

  const formatNumber = (num: number) => {
    if (num >= 1000000) return (num / 1000000).toFixed(1) + "M";
    if (num >= 1000) return (num / 1000).toFixed(1) + "K";
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
            <div
              className="circle"
              style={{ backgroundColor: c.color }}
            ></div>
          </div>
        ))}
      </div>
    </div>
  );
};

export default CovidDashboard;
