// tailwind.config.js
module.exports = {
  purge: [],
  darkMode: false, // or 'media' or 'class'
  theme: {
      extend: {
          screens: {
              'lg': '1400px',  // This is where we define the 1300px breakpoint
          }      },
  },
  variants: {
    extend: {},
  },
    plugins: [
        require('flowbite/plugin')
    ],
    content: [
        "./Views/Home/Index.cshtml",   // Đường dẫn tới các tệp Razor Views
        "./wwwroot/js/**/*.js",  // Đường dẫn tới các tệp JavaScript (nếu cần)
    ],
}