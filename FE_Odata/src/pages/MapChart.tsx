import React from "react";
import Plot from "react-plotly.js";
import "./MapChart.css";

export interface RecordAgg {
  CountryRegion: string;
  Date: string;
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

  return (
    <div className="mapchart-container">
      <h2 className="mapchart-title">{title}</h2>
      <div className="mapchart-plot">
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
                  `${r.CountryRegion}<br>Cases: ${r.LastValue}<br>Date: ${r.Date}`
              ),
              marker: { line: { color: "rgb(180,180,180)" } },
              colorbar: { title: colorbarTitle },
              hoverinfo: "text",
            },
          ]}
          layout={{
            autosize: true,
            margin: { l: 0, r: 0, t: 0, b: 0 },
          }}
          style={{ width: "100%", height: "100%" }}
          useResizeHandler={true}
        />
      </div>
    </div>
  );
};

export default MapChart;
