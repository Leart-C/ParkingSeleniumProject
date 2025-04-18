/** @type {import('tailwindcss').Config} */
export default {
  content: ["./index.html", "./src/**/*.{js,ts,jsx,tsx}"],
  theme: {
    extend: {
      colors: {
        "soft-purple": "rgba(117, 78, 180, 0.47)", // për tekst, sfond etj
      },
      borderColor: {
        "soft-purple": "rgba(117, 78, 180, 0.47)", // për borde
      },
    },
  },
  plugins: [],
};
