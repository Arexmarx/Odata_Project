import { useState, useEffect } from "react";
import { ResponsiveContainer, Treemap } from "recharts";
import "./CovidDashboard.css"; // import css thuần

// type cho country data
interface CountryData {
  country: string;
  value: number;
  percentage: number;
  color: string;
}

interface TreemapNode {
  name: string;
  value: number;
  percentage: number;
  fill: string;
}

const CovidDashboard = () => {
  const [activeTab, setActiveTab] = useState("Confirmed");
  const [worldData, setWorldData] = useState<CountryData[]>([]);
  const [treemapData, setTreemapData] = useState<TreemapNode[]>([]);
  const [loading, setLoading] = useState(true);

  // Mock data - replace with actual OData calls
  const mockWorldData = {
    Confirmed: [
      { country: "US", value: 52280854, percentage: 19, color: "#1e40af" },
      { country: "India", value: 34793333, percentage: 12, color: "#dc2626" },
      { country: "Brazil", value: 22243266, percentage: 8, color: "#059669" },
      { country: "UK", value: 11958928, percentage: 4, color: "#7c3aed" },
      { country: "Russia", value: 10213265, percentage: 4, color: "#ea580c" },
      { country: "France", value: 9220540, percentage: 3, color: "#ec4899" },
      { country: "Turkey", value: 9309094, percentage: 3, color: "#06b6d4" },
      { country: "Germany", value: 7009648, percentage: 3, color: "#65a30d" },
    ],
  };

  const mockTreemapData: TreemapNode[] = [
    { name: "US", value: 52280854, percentage: 19, fill: "#3b82f6" },
    { name: "India", value: 34793333, percentage: 12, fill: "#ef4444" },
    { name: "Brazil", value: 22243266, percentage: 8, fill: "#10b981" },
    { name: "United Kingdom", value: 11958928, percentage: 4, fill: "#8b5cf6" },
    { name: "Russia", value: 10213265, percentage: 4, fill: "#f97316" },
    { name: "France", value: 9220540, percentage: 3, fill: "#f472b6" },
    { name: "Turkey", value: 9309094, percentage: 3, fill: "#22d3ee" },
    { name: "Germany", value: 7009648, percentage: 3, fill: "#84cc16" },
  ];

  // Simulate OData API call
  const fetchODataData = async (endpoint: string, filter = "") => {
    try {
      setLoading(true);
      await new Promise((resolve) => setTimeout(resolve, 800));
      return {
        worldData: mockWorldData,
        treemapData: mockTreemapData,
      };
    } catch (error) {
      console.error("Error fetching OData:", error);
      return { worldData: {}, treemapData: [] };
    }
  };

  useEffect(() => {
    const loadData = async () => {
      const filter = `$filter=category eq '${activeTab}'&$top=50&$orderby=cases desc`;
      const data = await fetchODataData("/api/covid-data", filter);
      setWorldData(data.worldData[activeTab] || []);
      setTreemapData(data.treemapData);
      setLoading(false);
    };
    loadData();
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
          strokeWidth={2}
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
                stroke="#fff"
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
