import React, { useState, useEffect } from "react";
import axios from "axios";
import MapChart, { type RecordAgg } from "./MapChart";

type DataType = "confirmed" | "deaths" | "recovered" | "daily_reports";

const CovidMapTabs: React.FC = () => {
  const [type, setType] = useState<DataType>("confirmed");
  const [allData, setAllData] = useState<Record<string, RecordAgg[]>>({
    confirmed: [],
    deaths: [],
    recovered: [],
    daily_reports: [],
  });
  const [loading, setLoading] = useState(true);

  useEffect(() => {
    const fetchAllData = async () => {
      try {
        setLoading(true);

        // 🔹 Bước 1: Lấy ngày mới nhất từ Confirms
        const lastDateRes = await axios.get(
          "http://localhost:5230/odata/Confirms?$apply=aggregate(Date with max as LastDate)"
        );

        // OData thường trả về trong dạng { value: [{ LastDate: "2023-03-09" }] }
        const lastDate = lastDateRes.data?.[0]?.LastDate;
        if (!lastDate) {
          throw new Error("Không lấy được LastDate");
        }
        console.log("lastDate", lastDate);
        // 🔹 Bước 2: Tạo endpoints có filter theo lastDate
        const endpoints: Record<DataType, string> = {
          confirmed: `http://localhost:5230/odata/Confirms?$apply=filter(Date eq ${lastDate})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`,
          deaths: `http://localhost:5230/odata/Deaths?$apply=filter(Date eq ${lastDate})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`,
          recovered: `http://localhost:5230/odata/Recovereds?$apply=filter(Date eq ${lastDate})/groupby((CountryRegion, Date),aggregate(Value with sum as LastValue))`,
          daily_reports: "",
        };

        // 🔹 Bước 3: Gọi song song các API kia
        const results = await Promise.all(
          Object.entries(endpoints).map(async ([key, url]) => {
            if (!url) return [key, []] as [string, RecordAgg[]];
            const res = await axios.get(url);
            const data: RecordAgg[] = Array.isArray(res.data) ? res.data : [];
            return [key, data] as [string, RecordAgg[]];
          })
        );

        setAllData(Object.fromEntries(results));
        setLoading(false);
      } catch (err) {
        console.error(err);
        setLoading(false);
      }
    };

    fetchAllData();
  }, []);

  if (loading) return <div className="text-center p-6">Loading data...</div>;

  const renderMap = () => {
    switch (type) {
      case "confirmed":
        return (
          <MapChart
            data={allData.confirmed}
            title="COVID-19 Confirmed Cases"
            colorbarTitle="Confirmed"
          />
        );
      case "deaths":
        return (
          <MapChart
            data={allData.deaths}
            title="COVID-19 Deaths"
            colorbarTitle="Deaths"
          />
        );
      case "recovered":
        return (
          <MapChart
            data={allData.recovered}
            title="COVID-19 Recovered"
            colorbarTitle="Recovered"
          />
        );
    }
  };

  return (
    <div className="w-full max-w-6xl mx-auto p-6 bg-white shadow-lg rounded-xl">
      <div className="flex justify-center gap-4 mb-4">
        {(
          ["confirmed", "deaths", "recovered", "daily_reports"] as DataType[]
        ).map((t) => (
          <button
            key={t}
            className={`px-4 py-2 rounded ${
              type === t
                ? "bg-blue-600 text-white"
                : "bg-gray-200 text-gray-800"
            }`}
            onClick={() => setType(t)}
          >
            {t.replace("_", " ").toUpperCase()}
          </button>
        ))}
      </div>

      <div className="rounded-lg overflow-hidden border border-gray-200">
        {renderMap()}
      </div>
    </div>
  );
};

export default CovidMapTabs;
