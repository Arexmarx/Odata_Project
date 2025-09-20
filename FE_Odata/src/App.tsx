import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import CovidDashboard from "./pages/CovidDashboard";
import CovidMapTabs from "./pages/CovidMapTabs";
import CovidChart from "./pages/CovidChart";

function App() {
  return (
    <Router>
      <div>
        <h1>Demo OData</h1>

        {/* Nút chuyển trang */}
        <nav style={{ marginBottom: "16px" }}>
          <Link to="/dashboard" style={{ marginRight: "8px" }}>
            <button>Dashboard</button>
          </Link>
          <Link to="/map" style={{ marginRight: "8px" }}>
            <button>Map</button>
          </Link>
          <Link to="/chart">
            <button>Daily Report</button>
          </Link>
        </nav>

        {/* Định tuyến */}
        <Routes>
          <Route path="/dashboard" element={<CovidDashboard />} />
          <Route path="/chart" element={<CovidChart />} />
          <Route path="/map" element={<CovidMapTabs />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
