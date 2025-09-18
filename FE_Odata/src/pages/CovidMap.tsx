import React, { useState, useEffect } from "react";
import Plot from "react-plotly.js";
import axios from "axios";

interface ConfirmRecord {
  CountryRegion: string;
  ProvinceState: string | null;
  Date: string;
  Value: number;
}

const CovidMap: React.FC = () => {
  const [data, setData] = useState<ConfirmRecord[]>([]);

  useEffect(() => {
    const fetchData = async () => {
      try {
        // 🔹 Sử dụng $select để giảm dữ liệu
        const res = await axios.get(
          "http://localhost:5230/odata/Confirms?$select=CountryRegion,ProvinceState,Date,Value"
        );

        const records: ConfirmRecord[] = res.data?.value ?? [];

        // 🔹 Lọc record mới nhất cho mỗi quốc gia
        const latestByCountry = Object.values(
          records.reduce((acc, r) => {
            if (
              !acc[r.CountryRegion] ||
              new Date(r.Date) > new Date(acc[r.CountryRegion].Date)
            ) {
              acc[r.CountryRegion] = r;
            }
            return acc;
          }, {} as Record<string, ConfirmRecord>)
        );

        setData(latestByCountry);
      } catch (err) {
        console.error("Error fetching data:", err);
      }
    };

    fetchData();
  }, []);

  // Chuẩn bị dữ liệu cho Plotly
  const countries = data.map((d) => d.CountryRegion);
  const values = data.map((d) => d.Value);

  return (
    <div className="w-full max-w-6xl bg-white shadow-lg rounded-xl p-6">
      <h2 className="text-2xl font-bold text-center mb-4">
        COVID-19 Confirmed Cases (Latest)
      </h2>

      <div className="rounded-lg overflow-hidden border border-gray-200">
        <Plot
          data={[
            {
              type: "choropleth",
              locationmode: "country names",
              locations: countries,
              z: values,
              text: data.map(
                (d) =>
                  `${d.CountryRegion}${
                    d.ProvinceState ? " - " + d.ProvinceState : ""
                  }<br>Cases: ${d.Value}`
              ),
              colorscale: "Blues",
              marker: { line: { color: "rgb(180,180,180)" } },
              colorbar: { title: "Confirmed Cases" },
            },
          ]}
          layout={{
            geo: {
              showframe: false,
              showcoastlines: true,
              projection: { type: "mercator" },
            },
            margin: { l: 0, r: 0, t: 0, b: 0 },
          }}
          style={{ width: "100%", height: "700px" }}
        />
      </div>
    </div>
  );
};

export default CovidMap;
