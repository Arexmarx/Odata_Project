import React, { useState } from "react";
import Plot from "react-plotly.js";

interface CovidData {
  Country: string;
  ISO3: string;
  TotalConfirmed: number;
  TotalDeaths: number;
  TotalRecovered: number;
}

const mockData: CovidData[] = [
  {
    Country: "United States",
    ISO3: "USA",
    TotalConfirmed: 10000000,
    TotalDeaths: 500000,
    TotalRecovered: 6000000,
  },
  {
    Country: "India",
    ISO3: "IND",
    TotalConfirmed: 9000000,
    TotalDeaths: 400000,
    TotalRecovered: 7000000,
  },
  {
    Country: "Brazil",
    ISO3: "BRA",
    TotalConfirmed: 8000000,
    TotalDeaths: 350000,
    TotalRecovered: 6500000,
  },
  {
    Country: "Russia",
    ISO3: "RUS",
    TotalConfirmed: 6000000,
    TotalDeaths: 250000,
    TotalRecovered: 5000000,
  },
  {
    Country: "Vietnam",
    ISO3: "VNM",
    TotalConfirmed: 1200000,
    TotalDeaths: 25000,
    TotalRecovered: 1100000,
  },
];

const CovidMap: React.FC = () => {
  const [metric, setMetric] = useState<"Confirmed" | "Deaths" | "Recovered">(
    "Confirmed"
  );

  const countries = mockData.map((d) => d.ISO3);
  const values = mockData.map((d) => {
    if (metric === "Deaths") return d.TotalDeaths;
    if (metric === "Recovered") return d.TotalRecovered;
    return d.TotalConfirmed;
  });

  return (
    <div className="min-h-screen bg-gray-100 p-6 flex justify-center">
      <div className="w-full max-w-6xl bg-white shadow-lg rounded-xl p-6">
        {/* Title */}
        <h2 className="text-2xl font-bold text-gray-800 mb-4 text-center">
          COVID-19 {metric} Cases Worldwide
        </h2>

        {/* Buttons */}
        <div className="flex justify-center gap-4 mb-6">
          {["Confirmed", "Deaths", "Recovered"].map((type) => (
            <button
              key={type}
              onClick={() => setMetric(type as any)}
              className={`px-4 py-2 rounded-lg font-medium transition-colors ${
                metric === type
                  ? "bg-blue-600 text-white shadow-md"
                  : "bg-gray-100 text-gray-700 hover:bg-gray-200"
              }`}
            >
              {type}
            </button>
          ))}
        </div>

        {/* World Map */}
        <div className="rounded-lg overflow-hidden border border-gray-200">
          <Plot
            data={[
              {
                type: "choropleth",
                locations: countries,
                z: values,
                text: mockData.map(
                  (d) =>
                    `${d.Country}<br>${metric}: ${values[mockData.indexOf(d)]}`
                ),
                colorscale: "Blues",
                marker: { line: { color: "rgb(180,180,180)" } },
                colorbar: { title: `${metric} Cases` },
              },
            ]}
            layout={{
              geo: {
                showframe: false,
                showcoastlines: true,
                projection: { type: "mercator" },
                lataxis: { range: [-60, 85] },
              },
              margin: { l: 0, r: 0, t: 0, b: 0 },
            }}
            style={{ width: "100%", height: "700px" }}
          />
        </div>
      </div>
    </div>
  );
};

export default CovidMap;
