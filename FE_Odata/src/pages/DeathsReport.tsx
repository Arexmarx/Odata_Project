import React, { useState, useEffect } from "react";
import Plot from "react-plotly.js";
import "./DeathsReport.css";

export interface DeathsData {
  Date: string;
  TotalDeaths: number;
}

export interface DailyDeathsData {
  Date: string;
  DailyDeaths: number;
  TotalDeaths: number;
}

interface DeathsReportProps {
  apiUrl?: string;
}

const DeathsReport: React.FC<DeathsReportProps> = ({ 
  apiUrl = "http://localhost:5230/odata/Deaths?$apply=groupby((Date),%20aggregate(Value%20with%20sum%20as%20TotalDeaths))&$orderby=Date%20asc" 
}) => {
  const [data, setData] = useState<DailyDeathsData[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        setLoading(true);
        setError(null);
        
        const response = await fetch(apiUrl);
        if (!response.ok) {
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        
        const result = await response.json();
        
        // Handle OData response format
        const totalDeathsData: DeathsData[] = result.value || result;
        
        if (Array.isArray(totalDeathsData)) {
          // Calculate daily deaths: DailyDeaths(date) = TotalDeaths(date) - TotalDeaths(date-1)
          const dailyDeathsData: DailyDeathsData[] = totalDeathsData.map((item, index) => {
            const dailyDeaths = index === 0 
              ? item.TotalDeaths // First day: daily = total
              : item.TotalDeaths - totalDeathsData[index - 1].TotalDeaths;
            
            return {
              Date: item.Date,
              TotalDeaths: item.TotalDeaths,
              DailyDeaths: dailyDeaths
            };
          });
          
          setData(dailyDeathsData);
        } else {
          throw new Error("Invalid data format received");
        }
      } catch (err) {
        setError(err instanceof Error ? err.message : "An error occurred");
        console.error("Error fetching deaths data:", err);
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, [apiUrl]);

  if (loading) {
    return (
      <div className="deaths-report-container">
        <div className="loading">Loading deaths data...</div>
      </div>
    );
  }

  if (error) {
    return (
      <div className="deaths-report-container">
        <div className="error">Error: {error}</div>
      </div>
    );
  }

  if (!data || data.length === 0) {
    return (
      <div className="deaths-report-container">
        <div className="no-data">No deaths data available</div>
      </div>
    );
  }

  const dates = data.map(item => item.Date);
  const dailyDeaths = data.map(item => item.DailyDeaths);
  const totalDeaths = data.map(item => item.TotalDeaths);

  // Calculate statistics
  const maxDailyDeaths = Math.max(...dailyDeaths);
  const totalCumulativeDeaths = totalDeaths[totalDeaths.length - 1];
  const averageDailyDeaths = Math.round(dailyDeaths.reduce((sum, val) => sum + val, 0) / dailyDeaths.length);

  return (
    <div className="deaths-report-container">
      <h2 className="deaths-report-title">Global COVID-19 Daily Deaths Report</h2>
      <div className="deaths-report-stats">
        <div className="stat-item">
          <span className="stat-label">Total Records:</span>
          <span className="stat-value">{data.length}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Max Daily Deaths:</span>
          <span className="stat-value">{maxDailyDeaths.toLocaleString()}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Avg Daily Deaths:</span>
          <span className="stat-value">{averageDailyDeaths.toLocaleString()}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Total Cumulative:</span>
          <span className="stat-value">{totalCumulativeDeaths?.toLocaleString()}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Date Range:</span>
          <span className="stat-value">
            {dates[0]} - {dates[dates.length - 1]}
          </span>
        </div>
      </div>
      <div className="deaths-report-plot">
        <Plot
          data={[
            {
              x: dates,
              y: dailyDeaths,
              type: "scatter",
              mode: "lines+markers",
              name: "Daily Deaths",
              line: {
                color: "#dc3545",
                width: 2,
              },
              marker: {
                color: "#dc3545",
                size: 4,
              },
              hovertemplate: 
                "<b>Date:</b> %{x}<br>" +
                "<b>Daily Deaths:</b> %{y:,}<br>" +
                "<extra></extra>",
            },
          ]}
          layout={{
            title: {
              text: "Global COVID-19 Daily Deaths Over Time",
              font: { size: 18 },
            },
            xaxis: {
              title: "Date",
              type: "date",
              tickangle: -45,
            },
            yaxis: {
              title: "Daily Deaths",
              tickformat: ",",
            },
            hovermode: "x unified",
            showlegend: false,
            margin: { l: 80, r: 40, t: 80, b: 100 },
            plot_bgcolor: "#f8f9fa",
            paper_bgcolor: "white",
            font: { family: "Arial, sans-serif" },
          }}
          style={{ width: "100%", height: "500px" }}
          useResizeHandler={true}
          config={{
            displayModeBar: true,
            displaylogo: false,
            modeBarButtonsToRemove: ["pan2d", "lasso2d", "select2d"],
          }}
        />
      </div>
    </div>
  );
};

export default DeathsReport;