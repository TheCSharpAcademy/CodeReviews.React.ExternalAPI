import { Outlet } from "react-router-dom";
import "./App.css";
import { NavBar } from "./components/NavBar";
import SearchBar from "./components/SearchBar";

function App() {
  return (
    <>
      <NavBar />
      <div className="max-w-[1120px] mx-auto">
        <div className="flex flex-col">
          <SearchBar />
          <main className="flex items-center pl-4">
            <Outlet />
          </main>
        </div>
      </div>
    </>
  );
}

export default App;
