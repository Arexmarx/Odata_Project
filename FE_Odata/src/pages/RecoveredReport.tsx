import React, { useState, useEffect } from "react";
import Plot from "react-plotly.js";
import "./RecoveredReport.css";

export interface ConfirmedData {
  Date: string;
  TotalConfirmed: number;
}

export interface DeathsData {
  Date: string;
  TotalDeaths: number;
}

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
  confirmedApiUrl?: string;
  deathsApiUrl?: string;
}

const RecoveredReport: React.FC<RecoveredReportProps> = ({ 
  confirmedApiUrl = "http://localhost:5230/odata/Confirms?$apply=groupby((Date),%20aggregate(Value%20with%20sum%20as%20TotalConfirmed))&$orderby=Date%20asc",
  deathsApiUrl = "http://localhost:5230/odata/Deaths?$apply=groupby((Date),%20aggregate(Value%20with%20sum%20as%20TotalDeaths))&$orderby=Date%20asc"
}) => {
  const [data, setData] = useState<DailyRecoveredData[]>([]);
  const [loading, setLoading] = useState<boolean>(true);
  const [error, setError] = useState<string | null>(null);

  useEffect(() => {
    const fetchData = async () => {
      try {
        setLoading(true);
        setError(null);
        
        // Fetch both Confirmed and Deaths data
        const [confirmedResponse, deathsResponse] = await Promise.all([
          fetch(confirmedApiUrl),
          fetch(deathsApiUrl)
        ]);
        
        if (!confirmedResponse.ok) {
          throw new Error(`Confirmed API error! status: ${confirmedResponse.status}`);
        }
        if (!deathsResponse.ok) {
          throw new Error(`Deaths API error! status: ${deathsResponse.status}`);
        }
        
        const confirmedResult = await confirmedResponse.json();
        const deathsResult = await deathsResponse.json();
        
        // Handle OData response format
        const confirmedData: ConfirmedData[] = confirmedResult.value || confirmedResult;
        const deathsData: DeathsData[] = deathsResult.value || deathsResult;
        
        if (Array.isArray(confirmedData) && Array.isArray(deathsData)) {
          console.log("Confirmed data:", confirmedData.slice(0, 5)); // Debug first 5 items
          console.log("Deaths data:", deathsData.slice(0, 5)); // Debug first 5 items
          
          // Calculate recovered: Recovered = Confirmed - Deaths (by date)
          const recoveredByDate: RecoveredData[] = confirmedData.map((confirmedItem) => {
            const deathsItem = deathsData.find(d => d.Date === confirmedItem.Date);
            const totalRecovered = confirmedItem.TotalConfirmed - (deathsItem?.TotalDeaths || 0);
            
            return {
              Date: confirmedItem.Date,
              TotalRecovered: Math.max(0, totalRecovered) // Ensure non-negative
            };
          });
          
          // Calculate daily recovered: DailyRecovered(date) = TotalRecovered(date) - TotalRecovered(date-1)
          const dailyRecoveredData: DailyRecoveredData[] = recoveredByDate.map((item, index) => {
            const dailyRecovered = index === 0 
              ? item.TotalRecovered // First day: daily = total
              : item.TotalRecovered - recoveredByDate[index - 1].TotalRecovered;
            
            // Log negative values for debugging
            if (dailyRecovered < 0) {
              console.warn(`Negative daily value at ${item.Date}: ${dailyRecovered} (current: ${item.TotalRecovered}, previous: ${recoveredByDate[index - 1].TotalRecovered})`);
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
  }, [confirmedApiUrl, deathsApiUrl]);

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