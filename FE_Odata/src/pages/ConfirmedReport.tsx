import React, { useState, useEffect } from "react";
import Plot from "react-plotly.js";
import "./ConfirmedReport.css";

export interface ConfirmedData {
  Date: string;
  TotalConfirmed: number;
}

export interface DailyConfirmedData {
  Date: string;
  DailyConfirmed: number;
  TotalConfirmed: number;
}

interface ConfirmedReportProps {
  apiUrl?: string;
}

const ConfirmedReport: React.FC<ConfirmedReportProps> = ({ 
  apiUrl = "http://localhost:5230/odata/Confirms?$apply=groupby((Date),%20aggregate(Value%20with%20sum%20as%20TotalConfirmed))&$orderby=Date%20asc" 
}) => {
  const [data, setData] = useState<DailyConfirmedData[]>([]);
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
        const totalConfirmedData: ConfirmedData[] = result.value || result;
        
        if (Array.isArray(totalConfirmedData)) {
          // Calculate daily confirmed: DailyConfirmed(date) = TotalConfirmed(date) - TotalConfirmed(date-1)
          const dailyConfirmedData: DailyConfirmedData[] = totalConfirmedData.map((item, index) => {
            const dailyConfirmed = index === 0 
              ? item.TotalConfirmed // First day: daily = total
              : item.TotalConfirmed - totalConfirmedData[index - 1].TotalConfirmed;
            
            return {
              Date: item.Date,
              TotalConfirmed: item.TotalConfirmed,
              DailyConfirmed: dailyConfirmed
            };
          });
          
          setData(dailyConfirmedData);
        } else {
          throw new Error("Invalid data format received");
        }
      } catch (err) {
        setError(err instanceof Error ? err.message : "An error occurred");
        console.error("Error fetching confirmed data:", err);
      } finally {
        setLoading(false);
      }
    };

    fetchData();
  }, [apiUrl]);

  if (loading) {
    return (
      <div className="confirmed-report-container">
        <div className="loading">Loading confirmed cases data...</div>
      </div>
    );
  }

  if (error) {
    return (
      <div className="confirmed-report-container">
        <div className="error">Error: {error}</div>
      </div>
    );
  }

  if (!data || data.length === 0) {
    return (
      <div className="confirmed-report-container">
        <div className="no-data">No confirmed cases data available</div>
      </div>
    );
  }

  const dates = data.map(item => item.Date);
  const dailyConfirmed = data.map(item => item.DailyConfirmed);
  const totalConfirmed = data.map(item => item.TotalConfirmed);

  // Calculate statistics
  const maxDailyConfirmed = Math.max(...dailyConfirmed);
  const totalCumulativeConfirmed = totalConfirmed[totalConfirmed.length - 1];
  const averageDailyConfirmed = Math.round(dailyConfirmed.reduce((sum, val) => sum + val, 0) / dailyConfirmed.length);

  return (
    <div className="confirmed-report-container">
      <h2 className="confirmed-report-title">Global COVID-19 Daily Confirmed Cases Report</h2>
      <div className="confirmed-report-stats">
        <div className="stat-item">
          <span className="stat-label">Total Records:</span>
          <span className="stat-value">{data.length}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Max Daily Cases:</span>
          <span className="stat-value">{maxDailyConfirmed.toLocaleString()}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Avg Daily Cases:</span>
          <span className="stat-value">{averageDailyConfirmed.toLocaleString()}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Total Cumulative:</span>
          <span className="stat-value">{totalCumulativeConfirmed?.toLocaleString()}</span>
        </div>
        <div className="stat-item">
          <span className="stat-label">Date Range:</span>
          <span className="stat-value">
            {dates[0]} - {dates[dates.length - 1]}
          </span>
        </div>
      </div>
      <div className="confirmed-report-plot">
        <Plot
          data={[
            {
              x: dates,
              y: dailyConfirmed,
              type: "scatter",
              mode: "lines+markers",
              name: "Daily Confirmed Cases",
              line: {
                color: "#ffc107",
                width: 2,
              },
              marker: {
                color: "#ffc107",
                size: 4,
              },
              hovertemplate: 
                "<b>Date:</b> %{x}<br>" +
                "<b>Daily Confirmed:</b> %{y:,}<br>" +
                "<extra></extra>",
            },
          ]}
          layout={{
            title: {
              text: "Global COVID-19 Daily Confirmed Cases Over Time",
              font: { size: 18 },
            },
            xaxis: {
              title: "Date",
              type: "date",
              tickangle: -45,
            },
            yaxis: {
              title: "Daily Confirmed Cases",
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

export default ConfirmedReport;