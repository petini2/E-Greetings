namespace EGreetings_Project.Models.ViewModelAccount
{
    public class ECardViewModel
    {
        public List<Category> Categories { get; set; }  // Danh sách các categories
        public List<Template> Templates { get; set; }  // Danh sách các template
        public int CurrentPage { get; set; }  // Trang hiện tại
        public int TotalPages { get; set; }  // Tổng số trang

       
        public int TemplateID { get; set; }  // Template ID đã chọn
        public string ImgVer { get; set; }  // Ảnh dọc
        public string ImgHoz { get; set; }  // Ảnh ngang
    }
}
