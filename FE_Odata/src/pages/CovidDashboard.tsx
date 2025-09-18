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
  value?: number;
  percentage?: number;
  fill?: string;
  children?: TreeMapNode[];
}

const CovidDashboard = () => {
  const [activeTab, setActiveTab] = useState("Confirmed");
  const [worldData, setWorldData] = useState<CountryData[]>([]);
  const [treemapData, setTreemapData] = useState<TreeMapNode | null>(null);
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
    "#6366f1",
    "#ec4899",
    "#14b8a6",
    "#f59e0b",
  ];

  // Fetch OData
  const fetchODataData = async () => {
    try {
      setLoading(true);

      let arr: CountryData[] = [];
      const lastDateRes = await axios.get(
        "http://localhost:5230/odata/Confirms?$apply=aggregate(Date with max as LastDate)"
      );
      const lastDate = lastDateRes.data?.[0]?.LastDate;
      if (!lastDate) throw new Error("Không lấy được LastDate");

      if (activeTab === "Active") {
        // Tính Active = Confirmed - Deaths
        const [confirmedRes, deathsRes] = await Promise.all([
          axios.get(
            `http://localhost:5230/odata/Confirms?$apply=filter(Date eq ${lastDate})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`
          ),
          axios.get(
            `http://localhost:5230/odata/Deaths?$apply=filter(Date eq ${lastDate})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`
          ),
        ]);

        const confirmedData = confirmedRes.data.value || confirmedRes.data;
        const deathsData = deathsRes.data.value || deathsRes.data;

        arr = confirmedData.map((item: any, i: number) => {
          const deathsItem = deathsData.find(
            (d: any) => d.CountryRegion === item.CountryRegion
          );

          const confirmedVal = item.LastValue || 0;
          const deathsVal = deathsItem?.LastValue || 0;
          const activeVal = confirmedVal - deathsVal;

          return {
            country: item.CountryRegion || "Unknown",
            value: activeVal,
            percentage: 0,
            color: colors[i % colors.length],
          };
        });
      } else {
        const apiMap: Record<string, string> = {
          Confirmed: "Confirms",
          Recovered: "Recovereds",
          Deaths: "Deaths",
          "Daily Increase": "DailyReports",
        };

        const endpoint = apiMap[activeTab] || "Confirms";

        let url = "";

        if (activeTab === "Daily Increase") {
          url = `http://localhost:5230/odata/DailyReports?$apply=filter(Date eq max(Date))/groupby((CountryRegion), aggregate(Confirmed with sum as LastConfirmed))`;
        } else {
          // url = `http://localhost:5230/odata/${endpoint}?$apply=groupby((CountryRegion),aggregate(Date with max as LastDate,Value with max as LastValue))`;
          url = `http://localhost:5230/odata/${endpoint}?$apply=filter(Date eq ${lastDate})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`;
        }

        const res = await axios.get(url);
        const json = res.data;
        const rawData = json.value || json;

        arr = rawData.map((item: any, i: number) => ({
          country: item.CountryRegion || "Unknown",
          value:
            activeTab === "Daily Increase"
              ? item.LastConfirmed || 0
              : item.LastValue || 0,
          percentage: 0,
          color: colors[i % colors.length],
        }));
      }

      // Lọc bỏ value <= 0
      const filteredArr = arr.filter((item) => item.value > 0);

      // Tổng toàn cầu
      const total = filteredArr.reduce((sum, d) => sum + d.value, 0);

      // Tính %
      filteredArr.forEach((d) => {
        d.percentage = total > 0 ? +((d.value / total) * 100).toFixed(1) : 0;
      });

      // Sort giảm dần
      filteredArr.sort((a, b) => b.value - a.value);

      const root: TreeMapNode = {
        name: "root",
        children: filteredArr.map((d) => ({
          name: d.country,
          value: d.value,
          percentage: d.percentage,
          fill: d.color,
        })),
      };

      setTreemapData(root);
      setWorldData(filteredArr);
    } catch (error) {
      console.error("Error fetching OData:", error);
      setWorldData([]);
      setTreemapData(null);
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

    return (
      <g>
        <rect
          x={x}
          y={y}
          width={width}
          height={height}
          fill={fill}
          stroke="#fff"
          strokeWidth={1}
        />

        {width > 80 && height > 50 && (
          <>
            <text
              x={x + width / 2}
              y={y + height / 2 - 10}
              textAnchor="middle"
              fill="white"
              fontSize={Math.min(12, width / 8)}
              fontWeight="bold"
            >
              {name.length > 15 ? name.substring(0, 12) + "..." : name}
            </text>
            <text
              x={x + width / 2}
              y={y + height / 2 + 5}
              textAnchor="middle"
              fill="white"
              fontSize={Math.min(11, width / 9)}
            >
              {formatNumber(value)}
            </text>
            <text
              x={x + width / 2}
              y={y + height / 2 + 20}
              textAnchor="middle"
              fill="white"
              fontSize={Math.min(10, width / 10)}
            >
              {percentage}%
            </text>
          </>
        )}
        {width > 40 && height > 25 && width <= 80 && height <= 110 && (
          <>
            <text
              x={x + width / 2}
              y={y + height / 2 - 10}
              textAnchor="middle"
              fill="white"
              fontSize={Math.min(12, width / 8)}
              fontWeight="bold"
            >
              {name.length > 15 ? name.substring(0, 12) + "..." : name}
            </text>
            <text
              x={x + width / 2}
              y={y + height / 2}
              textAnchor="middle"
              fill="white"
              fontSize={Math.min(10, width / 6)}
              fontWeight="bold"
            >
              {formatNumber(value)}
            </text>
            <text
              x={x + width / 2}
              y={y + height / 2 + 20}
              textAnchor="middle"
              fill="white"
              fontSize={Math.min(10, width / 10)}
            >
              {percentage}%
            </text>
          </>
        )}

        {width > 40 && height > 25 && width <= 80 && height <= 50 && (
          <text
            x={x + width / 2}
            y={y + height / 2}
            textAnchor="middle"
            fill="white"
            fontSize={Math.min(10, width / 6)}
            fontWeight="bold"
          >
            {formatNumber(value)}
          </text>
        )}

        {width <= 40 || height <= 25 ? (
          <text
            x={x + width / 2}
            y={y + height / 2}
            textAnchor="middle"
            fill="white"
            fontSize={7}
            fontWeight="bold"
          >
            {formatNumber(value)}
          </text>
        ) : null}
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
        <h3>Treemap of Countries - {activeTab}</h3>
        <p className="subtitle">
          The Treemap shows the number of {activeTab.toLowerCase()} cases in
          different countries and their percentage worldwide
        </p>

        <div className="treemap-container">
          {loading ? (
            <div className="loading">Loading...</div>
          ) : treemapData ? (
            <ResponsiveContainer width="100%" height="100%">
              <Treemap
                data={treemapData.children as any}
                dataKey="value"
                content={<CustomTreemapContent />}
              />
            </ResponsiveContainer>
          ) : (
            <div className="loading">No data available</div>
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

      {!loading && (
        <div style={{ marginTop: "20px", fontSize: "12px", color: "#666" }}>
          Total countries: {worldData.length} | Total cases:{" "}
          {worldData.reduce((sum, d) => sum + d.value, 0).toLocaleString()}
        </div>
      )}
    </div>
  );
};

export default CovidDashboard;
