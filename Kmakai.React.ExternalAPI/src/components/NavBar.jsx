import { Link } from "react-router-dom";
import { FaUtensils } from "react-icons/fa";

export const NavBar = () => {
  return (
    <nav className="shadow h-14 pl-4 flex items-center sticky top-0 bg-white">
      <Link
        to={`/`}
        className="text-2xl font-bold px-2 text-slate-800 flex items-center gap-2"
      >
        <span className="icon">
          <FaUtensils />
        </span>
        MealTime
      </Link>
    </nav>
  );
};
