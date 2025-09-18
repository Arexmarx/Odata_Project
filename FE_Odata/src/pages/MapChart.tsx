import React from "react";
import Plot from "react-plotly.js";

export interface RecordAgg {
  CountryRegion: string;
  LastDate: string;
  LastValue: number;
}

interface MapChartProps {
  data: RecordAgg[];
  title: string;
  colorbarTitle: string;
}

const MapChart: React.FC<MapChartProps> = ({ data, title, colorbarTitle }) => {
  const values = data.map((r) => r.LastValue);
  const countries = data.map((r) => r.CountryRegion);
  const zmax = Math.max(...values, 0);
  console.log("check", { data, title, colorbarTitle });
  return (
    <div>
      <h2 className="text-xl font-bold text-center mb-2">{title}</h2>
      <Plot
        data={[
          {
            type: "choropleth",
            locationmode: "country names",
            locations: countries,
            z: values,
            zmin: 0,
            zmax,
            colorscale: "Blues_r",
            text: data.map(
              (r) =>
                `${r.CountryRegion}<br>Cases: ${r.LastValue}<br>Date: ${r.LastDate}`
            ),
            marker: { line: { color: "rgb(180,180,180)" } },
            colorbar: { title: colorbarTitle },
            hoverinfo: "text",
          },
        ]}
        layout={{ autosize: true }}
      />
    </div>
  );
};

export default MapChart;
