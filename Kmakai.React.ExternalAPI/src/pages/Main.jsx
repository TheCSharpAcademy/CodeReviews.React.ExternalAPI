import { Link } from "react-router-dom";
import { Categories } from "../data";
import CategoryCard from "../components/CategoryCard";

const Main = () => {
  return (
    <div className="p-4">
      <p className="text-2xl">What are you in the mood for?</p>
      <p className="text-gray-500">
        Choose a category to see what recipes we have for you!
      </p>
      <div className="flex flex-wrap gap-2">
        {Categories.map((c, ind) => (
          <Link
            key={ind}
            // onClick={async () => await getMealsByCategory(c.strCategory)}
            to={`/search?c=${c.strCategory}`}
          >
            <CategoryCard key={ind} category={c} />
          </Link>
        ))}
      </div>
    </div>
  );
};

export default Main;
