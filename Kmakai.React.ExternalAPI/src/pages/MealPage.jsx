import { useLoaderData } from "react-router-dom";
import { getMealById } from "../fetchers";

export async function loader({ request }) {
  const url = new URL(request.url);
  const mealId = url.pathname.split("/")[2];
  const meal = await getMealById(mealId);
  return { meal };
}

const MealPage = () => {
  const { meal } = useLoaderData();
  return (
    <div className="flex-1 flex flex-col gap-4 p-2">
      <div className="flex flex-wrap gap-10">
        <div className="flex flex-col gap-4 mt-2">
          <img
            src={meal.strMealThumb}
            alt={meal.strMeal}
            className="max-h-[500px] rounded w-[500px]"
          />
          <span className="text-blue-800 max-w-[500px]">
            Source link:
            <br />
            <a href={meal.strSource} className="">
              {meal.strSource}
            </a>
          </span>

          <span className="text-blue-800">
            Video link:
            <br />
            <a href={meal.strYoutube}>{meal.strYoutube}</a>
          </span>
        </div>

        <div className="flex-1 flex flex-col gap-2 justify-between">
          <h1 className="font-bold text-2xl italic text-slate-700 underline underline-offset-4 mb-2">
            {meal.strMeal}
          </h1>{" "}
          <div className=" bg-slate-200 p-2 text-slate-600 rounded-md">
            <h2 className="font-bold text-lg text-slate-700 mb-2">
              Ingredients
            </h2>
            <ul className="flex flex-col max-w-[500px]">
              {getIngredients(meal).map((ingredient) => ingredient)}
            </ul>
          </div>
          <div className="flex flex-col gap-2 mt-4  bg-slate-200 p-2 text-slate-800 rounded-md text-[18px]">
            <h2 className="font-bold text-lg text-slate-700">Instructions</h2>
            {meal.strInstructions.split(".").map((s, i) => (
              <p key={i}>{s}.</p>
            ))}
          </div>
        </div>
      </div>
    </div>
  );
};

function getIngredients(meal) {
  const ingredients = [];
  for (let i = 1; i <= 20; i++) {
    if (meal[`strIngredient${i}`]) {
      ingredients.push(
        <li key={i} className="flex gap-10 justify-between font-semibold">
          <span className="capitalize">{meal[`strIngredient${i}`]}</span>
          <span>{meal[`strMeasure${i}`]}</span>
        </li>
      );
    }
  }
  return ingredients;
}

export default MealPage;
