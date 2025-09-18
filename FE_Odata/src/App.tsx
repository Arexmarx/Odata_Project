import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";
import CovidDashboard from "./pages/CovidDashboard";
import CovidMapTabs from "./pages/CovidMapTabs";

function App() {
  return (
    <Router>
      <div>
        <h1>Demo Temp Data</h1>

        {/* Nút chuyển trang */}
        <nav style={{ marginBottom: "16px" }}>
          <Link to="/dashboard" style={{ marginRight: "8px" }}>
            <button>Dashboard</button>
          </Link>
          <Link to="/map">
            <button>Map</button>
          </Link>
        </nav>

        {/* Định tuyến */}
        <Routes>
          <Route path="/dashboard" element={<CovidDashboard />} />
          <Route path="/map" element={<CovidMapTabs />} />
        </Routes>
      </div>
    </Router>
  );
}

export default App;
