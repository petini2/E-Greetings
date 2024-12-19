// tailwind.config.js
module.exports = {
  purge: [],
  darkMode: false, // or 'media' or 'class'
  theme: {
    extend: {},
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