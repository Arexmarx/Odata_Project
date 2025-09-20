import React, { useState, useEffect } from "react";
import Plot from "react-plotly.js";
import "./RecoveredReport.css";

export interface RecoveredData {
  Date: string;
  TotalRecovered: number;
}

export interface DailyRecoveredData {
  Date: string;
  DailyRecovered: number;
  TotalRecovered: number;
}

interface RecoveredReportProps {
  apiUrl?: string;
}

const RecoveredReport: React.FC<RecoveredReportProps> = ({ 
  apiUrl = "http://localhost:5230/odata/Recovereds?$apply=groupby((Date),%20aggregate(Value%20with%20sum%20as%20TotalRecovered))&$orderby=Date%20asc" 
}) => {
  const [data, setData] = useState<DailyRecoveredData[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        setLoading(true);
        setError(null);
        
        const response = await fetch(apiUrl);
        if (!response.ok) {
            console.log("Fetch error:", response);
          throw new Error(`HTTP error! status: ${response.status}`);
        }
        
        const result = await response.json();
        
        // Handle OData response format
        const totalRecoveredData: RecoveredData[] = result.value || result;
        
        if (Array.isArray(totalRecoveredData)) {
          console.log("Total recovered data:", totalRecoveredData.slice(0, 5)); // Debug first 5 items
          
          // Calculate daily recovered: DailyRecovered(date) = TotalRecovered(date) - TotalRecovered(date-1)
          const dailyRecoveredData: DailyRecoveredData[] = totalRecoveredData.map((item, index) => {
            const dailyRecovered = index === 0 
              ? item.TotalRecovered // First day: daily = total
              : item.TotalRecovered - totalRecoveredData[index - 1].TotalRecovered;
            
            // Log negative values for debugging
            if (dailyRecovered < 0) {
              console.warn(`Negative daily value at ${item.Date}: ${dailyRecovered} (current: ${item.TotalRecovered}, previous: ${totalRecoveredData[index - 1].TotalRecovered})`);
            }
            
            return {
              Date: item.Date,
              TotalRecovered: item.TotalRecovered,
              DailyRecovered: Math.max(0, dailyRecovered) // Ensure non-negative values
            };
          });
          
          console.log("Daily recovered data:", dailyRecoveredData.slice(0, 5)); // Debug first 5 items
          setData(dailyRecoveredData);
        } else {
          throw new Error("Invalid data format received");
        }
      } catch (err) {
        setError(err instanceof Error ? err.message : "An error occurred");
        console.error("Error fetching recovered data:", err);
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, [apiUrl]);

  if (loading) {
    return (
      <div className="recovered-report-container">
        <div className="loading">Loading recovered cases data...</div>
      </div>
    );
  }

  if (error) {
    return (
      <div className="recovered-report-container">
        <div className="error">Error: {error}</div>
      </div>
    );
  }

  if (!data || data.length === 0) {
    return (
      <div className="recovered-report-container">
        <div className="no-data">No recovered cases data available</div>
      </div>
    );
  }

  const dates = data.map(item => item.Date);
  const dailyRecovered = data.map(item => item.DailyRecovered);
  const totalRecovered = data.map(item => item.TotalRecovered);

  // Calculate statistics
  const maxDailyRecovered = Math.max(...dailyRecovered);
  const totalCumulativeRecovered = totalRecovered[totalRecovered.length - 1];
  const averageDailyRecovered = Math.round(dailyRecovered.reduce((sum, val) => sum + val, 0) / dailyRecovered.length);

  return (
    <div className="recovered-report-container">
      <h2 className="recovered-report-title">Global COVID-19 Daily Recovered Cases Report</h2>
      
      {/* Debug Panel */}
      <div style={{ 
        background: "#f0f0f0", 
        padding: "10px", 
        margin: "10px 0", 
        borderRadius: "4px",
        fontSize: "12px",
        fontFamily: "monospace"
      }}>
        <strong>Debug Info:</strong><br/>
        API URL: {apiUrl}<br/>
        Data length: {data.length}<br/>
        Sample data: {data.length > 0 ? JSON.stringify(data.slice(0, 2), null, 2) : "No data"}
      </div>

      <div className="recovered-report-stats">
        <div className="stat-item">
          <span className="stat-label">Total Records:</span>
          <span className="stat-value">{data.length}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Max Daily Recovered:</span>
          <span className="stat-value">{maxDailyRecovered.toLocaleString()}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Avg Daily Recovered:</span>
          <span className="stat-value">{averageDailyRecovered.toLocaleString()}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Total Cumulative:</span>
          <span className="stat-value">{totalCumulativeRecovered?.toLocaleString()}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Date Range:</span>
          <span className="stat-value">
            {dates[0]} - {dates[dates.length - 1]}
          </span>
        </div>
      </div>
      <div className="recovered-report-plot">
        <Plot
          data={[
            {
              x: dates,
              y: dailyRecovered,
              type: "scatter",
              mode: "lines+markers",
              name: "Daily Recovered Cases",
              line: {
                color: "#28a745",
                width: 2,
              },
              marker: {
                color: "#28a745",
                size: 4,
              },
              hovertemplate: 
                "<b>Date:</b> %{x}<br>" +
                "<b>Daily Recovered:</b> %{y:,}<br>" +
                "<extra></extra>",
            },
          ]}
          layout={{
            title: {
              text: "Global COVID-19 Daily Recovered Cases Over Time",
              font: { size: 18 },
            },
            xaxis: {
              title: "Date",
              type: "date",
              tickangle: -45,
            },
            yaxis: {
              title: "Daily Recovered Cases",
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

export default RecoveredReport;