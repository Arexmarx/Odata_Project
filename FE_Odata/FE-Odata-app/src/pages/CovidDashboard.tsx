import { useState, useEffect } from "react";
import {
  ResponsiveContainer,
  Treemap,
} from "recharts";

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
  const [activeTab, setActiveTab] = useState('Confirmed');
  const [worldData, setWorldData] = useState([]);
  const [treemapData, setTreemapData] = useState([]);
  const [loading, setLoading] = useState(true);

  // Mock data - replace with actual OData calls
  const mockWorldData = {
    Confirmed: [
      { country: 'US', value: 52280854, percentage: 19, color: '#1e40af' },
      { country: 'India', value: 34793333, percentage: 12, color: '#dc2626' },
      { country: 'Brazil', value: 22243266, percentage: 8, color: '#059669' },
      { country: 'UK', value: 11958928, percentage: 4, color: '#7c3aed' },
      { country: 'Russia', value: 10213265, percentage: 4, color: '#ea580c' },
      { country: 'France', value: 9220540, percentage: 3, color: '#ec4899' },
      { country: 'Turkey', value: 9309094, percentage: 3, color: '#06b6d4' },
      { country: 'Germany', value: 7009648, percentage: 3, color: '#65a30d' },
    ]
  };

  const mockTreemapData = [
    { name: 'US', value: 52280854, percentage: 19, fill: '#3b82f6' },
    { name: 'India', value: 34793333, percentage: 12, fill: '#ef4444' },
    { name: 'Brazil', value: 22243266, percentage: 8, fill: '#10b981' },
    { name: 'United Kingdom', value: 11958928, percentage: 4, fill: '#8b5cf6' },
    { name: 'Russia', value: 10213265, percentage: 4, fill: '#f97316' },
    { name: 'France', value: 9220540, percentage: 3, fill: '#f472b6' },
    { name: 'Turkey', value: 9309094, percentage: 3, fill: '#22d3ee' },
    { name: 'Germany', value: 7009648, percentage: 3, fill: '#84cc16' },
    { name: 'Iran', value: 6184762, percentage: 2, fill: '#f59e0b' },
    { name: 'Argentina', value: 5460042, percentage: 2, fill: '#a855f7' },
    { name: 'Italy', value: 5647313, percentage: 2, fill: '#6366f1' },
    { name: 'Colombia', value: 5124690, percentage: 2, fill: '#14b8a6' },
    { name: 'Poland', value: 4049838, percentage: 1, fill: '#f97316' },
    { name: 'Mexico', value: 3950200, percentage: 1, fill: '#06b6d4' },
    { name: 'Ukraine', value: 3823879, percentage: 1, fill: '#8b5cf6' },
    { name: 'South Africa', value: 3413540, percentage: 1, fill: '#84cc16' },
    { name: 'Netherlands', value: 3109758, percentage: 1, fill: '#f59e0b' },
    { name: 'Philippines', value: 2838640, percentage: 1, fill: '#ef4444' },
    { name: 'Malaysia', value: 2741179, percentage: 1, fill: '#3b82f6' },
    { name: 'Peru', value: 2278807, percentage: 1, fill: '#10b981' },
    { name: 'Thailand', value: 2212407, percentage: 1, fill: '#f472b6' },
    { name: 'Iraq', value: 2092484, percentage: 1, fill: '#f97316' },
    { name: 'Belgium', value: 2038111, percentage: 1, fill: '#6366f1' },
    { name: 'Canada', value: 1995809, percentage: 1, fill: '#ef4444' }
  ];

  // Simulate OData API call
  const fetchODataData = async (endpoint, filter = '') => {
    try {
      setLoading(true);
      // Replace with actual OData endpoint
      // const response = await fetch(`${endpoint}?${filter}`);
      // const data = await response.json();
      
      // Simulate API delay
      await new Promise(resolve => setTimeout(resolve, 1000));
      
      // Return mock data for demonstration
      return {
        worldData: mockWorldData,
        treemapData: mockTreemapData
      };
    } catch (error) {
      console.error('Error fetching OData:', error);
      return { worldData: {}, treemapData: [] };
    }
  };

  useEffect(() => {
    const loadData = async () => {
      const filter = `$filter=category eq '${activeTab}'&$top=50&$orderby=cases desc`;
      const data = await fetchODataData('/api/covid-data', filter);
      
      setWorldData(data.worldData[activeTab] || []);
      setTreemapData(data.treemapData);
      setLoading(false);
    };

    loadData();
  }, [activeTab]);

  const tabs = ['Confirmed', 'Active', 'Recovered', 'Deaths', 'Daily Increase'];

  const formatNumber = (num) => {
    if (num >= 1000000) {
      return (num / 1000000).toFixed(1) + 'M';
    }
    if (num >= 1000) {
      return (num / 1000).toFixed(1) + 'K';
    }
    return num.toString();
  };

  const CustomTreemapContent = (props) => {
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
          strokeWidth={2}
        />
        {width > 100 && height > 60 && (
          <>
            <text
              x={x + width / 2}
              y={y + height / 2 - 10}
              textAnchor="middle"
              dominantBaseline="middle"
              fill="white"
              fontSize={width > 200 ? 14 : 12}
              fontWeight="bold"
            >
              {name}
            </text>
            <text
              x={x + width / 2}
              y={y + height / 2 + 5}
              textAnchor="middle"
              dominantBaseline="middle"
              fill="white"
              fontSize={width > 200 ? 12 : 10}
            >
              {formatNumber(value)}
            </text>
            <text
              x={x + width / 2}
              y={y + height / 2 + 20}
              textAnchor="middle"
              dominantBaseline="middle"
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

  const WorldMap = () => {
    const countryPaths = {
      US: "M 200 180 L 350 180 L 350 260 L 200 260 Z",
      India: "M 680 220 L 750 220 L 750 280 L 680 280 Z",
      Brazil: "M 320 320 L 420 320 L 420 420 L 320 420 Z",
      // Add more country paths as needed
    };

    return (
      <div className="bg-white rounded-lg p-6 shadow-lg">
        <h3 className="text-lg font-semibold text-gray-800 mb-4"># of Cases World wide</h3>
        
        <div className="mb-6">
          <div className="flex flex-wrap gap-2">
            {tabs.map((tab) => (
              <button
                key={tab}
                onClick={() => setActiveTab(tab)}
                className={`px-4 py-2 rounded-md border transition-colors ${
                  activeTab === tab
                    ? 'bg-blue-100 border-blue-300 text-blue-700'
                    : 'bg-gray-50 border-gray-300 text-gray-600 hover:bg-gray-100'
                }`}
              >
                {tab}
              </button>
            ))}
          </div>
        </div>

        <div className="relative bg-gray-50 rounded-lg p-4" style={{ height: '400px' }}>
          <svg width="100%" height="100%" viewBox="0 0 900 400">
            {/* World map outline */}
            <path
              d="M 50 100 Q 100 80 200 90 L 300 95 Q 400 90 500 100 L 600 105 Q 700 100 800 110 L 850 120 L 850 300 Q 800 320 700 310 L 600 305 Q 500 300 400 305 L 300 300 Q 200 305 100 290 L 50 280 Z"
              fill="#e5e7eb"
              stroke="#d1d5db"
            />
            
            {/* Country highlighting based on data */}
            {worldData.slice(0, 5).map((country, index) => (
              <rect
                key={country.country}
                x={100 + index * 150}
                y={150}
                width={120}
                height={80}
                fill={country.color}
                opacity={0.7}
                rx={4}
              />
            ))}
            
            {/* Legend */}
            <g transform="translate(50, 350)">
              <rect x="0" y="0" width="15" height="15" fill="#1e40af" />
              <text x="20" y="12" fontSize="12" fill="#374151">High</text>
              <rect x="80" y="0" width="15" height="15" fill="#60a5fa" />
              <text x="100" y="12" fontSize="12" fill="#374151">Medium</text>
              <rect x="180" y="0" width="15" height="15" fill="#dbeafe" />
              <text x="200" y="12" fontSize="12" fill="#374151">Low</text>
            </g>
          </svg>
          
          {loading && (
            <div className="absolute inset-0 flex items-center justify-center bg-white bg-opacity-75">
              <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600"></div>
            </div>
          )}
        </div>
      </div>
    );
  };

  return (
    <div className="min-h-screen bg-gray-100 p-6">
      <div className="max-w-7xl mx-auto space-y-6">
        {/* World Map Section */}
        <WorldMap />

        {/* Treemap Section */}
        <div className="bg-white rounded-lg p-6 shadow-lg">
          <div className="mb-4">
            <h3 className="text-lg font-semibold text-gray-800">Treemap of Countries</h3>
            <p className="text-sm text-gray-600">
              The Treemap shows the number of Cases in Different countries and their percent of total cases worldwide
            </p>
          </div>

          <div className="mb-4">
            <div className="flex flex-wrap gap-2 text-xs">
              {['Confirmed', 'Active', 'Recovered', 'Deaths', 'Daily Increase'].map((type, index) => {
                const colors = ['#3b82f6', '#10b981', '#f59e0b', '#ef4444', '#8b5cf6'];
                return (
                  <div key={type} className="flex items-center gap-1">
                    <div 
                      className="w-3 h-3 rounded" 
                      style={{ backgroundColor: colors[index] }}
                    ></div>
                    <span className="text-gray-600">{type}</span>
                  </div>
                );
              })}
            </div>
          </div>

          <div style={{ width: '100%', height: '500px' }}>
            {loading ? (
              <div className="flex items-center justify-center h-full">
                <div className="animate-spin rounded-full h-8 w-8 border-b-2 border-blue-600"></div>
              </div>
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

        {/* Statistics Cards */}
        <div className="grid grid-cols-1 md:grid-cols-2 lg:grid-cols-4 gap-4">
          {worldData.slice(0, 4).map((country, index) => (
            <div key={country.country} className="bg-white rounded-lg p-4 shadow">
              <div className="flex items-center justify-between">
                <div>
                  <p className="text-sm font-medium text-gray-600">{country.country}</p>
                  <p className="text-2xl font-bold text-gray-900">
                    {formatNumber(country.value)}
                  </p>
                  <p className="text-sm text-gray-500">{country.percentage}% of total</p>
                </div>
                <div 
                  className="w-12 h-12 rounded-full opacity-20"
                  style={{ backgroundColor: country.color }}
                ></div>
              </div>
            </div>
          ))}
        </div>
      </div>
    </div>
  );
};

export default CovidDashboard;