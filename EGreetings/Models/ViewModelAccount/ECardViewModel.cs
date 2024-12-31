namespace EGreetings.Models.ViewModelAccount
{
    public class ECardViewModel
    {
        public List<Category> Categories { get; set; }  // List of categories
        public List<Template> Templates { get; set; }  // List of templates
        public string? UserID { get; set; }
        public int CurrentPage { get; set; }  // Current page
        public int TotalPages { get; set; }  // Total number of pages
        public int CategoryId { get; set; }  // Selected category ID
        public List<int> SelectedCategories { get; set; } = new List<int>();  // Selected category IDs
        public List<string> SelectedGroupCategories { get; set; } = new List<string>();  // Selected group category IDs
        public int TemplateID { get; set; }  // Selected template ID
        public string ImgVer { get; set; }  // Vertical image
        public string ImgHoz { get; set; }  // Horizontal image
        public string? SVGVer { get; set; }  // Vertical SVG image
        public string? SVGHoz { get; set; }  // Horizontal SVG image
        public string? SearchQuery { get; set; }  // Search query
        public string PriceFilter { get; set; }  // Price filter option
        public string? GroupCate { get; set; }
        public int? SubId { get; set; }
    }
}