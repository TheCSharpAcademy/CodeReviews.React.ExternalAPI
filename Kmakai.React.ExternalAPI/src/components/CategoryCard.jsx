const CategoryCard = ({ category }) => {
  return (
    <div className="flex items-end justify-center gap-1 border rounded-md py-2 hover:-translate-y-1 shadow-sm hover:shadow-md transition ease-in min-w-fit">
      <span className="text-2xl">{category.icon}</span>
      <span className="font-semibold px-2">{category.strCategory}</span>
    </div>
  );
};

export default CategoryCard;
