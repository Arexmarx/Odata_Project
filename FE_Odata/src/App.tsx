import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import CovidDashboard from "./pages/CovidDashboard";
import CovidMapTabs from "./pages/CovidMapTabs";
import CovidChart from "./pages/CovidChart";
import DeathsReport from "./pages/DeathsReport";
import ConfirmedReport from "./pages/ConfirmedReport";
import RecoveredReport from "./pages/RecoveredReport";

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
          <Link to="/chart" style={{ marginRight: "8px" }}>
            <button>Daily Report</button>
          </Link>
          <Link to="/deaths" style={{ marginRight: "8px" }}>
            <button>Deaths Report</button>
          </Link>
          <Link to="/confirmed" style={{ marginRight: "8px" }}>
            <button>Confirmed Report</button>
          </Link>
          <Link to="/recovered">
            <button>Recovered Report</button>
          </Link>
        </nav>

        {/* Định tuyến */}
        <Routes>
          <Route path="/dashboard" element={<CovidDashboard />} />
          <Route path="/chart" element={<CovidChart />} />
          <Route path="/map" element={<CovidMapTabs />} />
          <Route path="/deaths" element={<DeathsReport />} />
          <Route path="/confirmed" element={<ConfirmedReport />} />
          <Route path="/recovered" element={<RecoveredReport />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
