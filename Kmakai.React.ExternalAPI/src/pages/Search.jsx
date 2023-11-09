import { Link, useLoaderData } from "react-router-dom";
import { getMealsByName, getMealsByCategory } from "../fetchers";

export async function loader({ request }) {
  const url = new URL(request.url);
  const c = url.searchParams.get("c");
  const q = url.searchParams.get("q");
  let meals = [];

  if (c) {
    meals = await getMealsByCategory(c);
  } else if (q) {
    meals = await getMealsByName(q);
  }
  return { meals };
}

const MealCard = ({ meal }) => {
  return (
    <div className="flex flex-col gap-1 border rounded-md transition ease-in overflow-hidden pb-2 w-40 items-center hover:cursor-pointer hover:scale-110 h-full text-center">
      <img
        src={meal.strMealThumb}
        alt={meal.strMeal}
        className="w-40 hover:scale-110 transition ease-in"
      />
      <span className="font-semibold px-2 text-slate-600 mt-4">
        {meal.strMeal}
      </span>
    </div>
  );
};

const Search = () => {
  const { meals } = useLoaderData();

  return (
    <div className="flex flex-wrap gap-2 p-2">
      {meals && meals.length > 0 ? (
        meals.map((meal, ind) => (
          <Link key={meal.idMeal} to={`/meals/${meal.idMeal}`}>
            <MealCard key={ind} meal={meal} />
          </Link>
        ))
      ) : (
        <h1>No results found</h1>
      )}
    </div>
  );
};

export default Search;
