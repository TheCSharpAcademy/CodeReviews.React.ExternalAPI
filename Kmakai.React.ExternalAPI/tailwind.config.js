/** @type {import('tailwindcss').Config} */
export default {
  content: ["./index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  theme: {
    screens: {
      xs: "475px",
      sm: "625px",
      md: "760px",
      lg: "1024px",
    },
    extend: {},
  },
  plugins: [],
};
