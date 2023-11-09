import { Form, useNavigate } from "react-router-dom";

const SearchBar = () => {
  const navigate = useNavigate();
  return (
    <div className="p-6">
      <Form
        id="search-form"
        action="search"
        onSubmit={(e) => {
          e.preventDefault();
          const form = document.getElementById("search-form");
          const formData = new FormData(form);
          const searchQuery = formData.get("q");
          navigate(`/search?q=${searchQuery}`);
        }}
      >
        <input
          type="text"
          name="q"
          id="q"
          placeholder="Know what you want? Search for it here!"
          className="border-2 rounded p-2 rounded-r-none sm:w-80"
        />
        <button
          type="submit"
          className="bg-blue-500 hover:bg-blue-700 text-white font-bold py-2 px-4 rounded rounded-l-none border-blue-500 border-2"
        >
          Search
        </button>
      </Form>
    </div>
  );
};

export default SearchBar;
