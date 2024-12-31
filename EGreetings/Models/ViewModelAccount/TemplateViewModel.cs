namespace EGreetings.Models.ViewModelAccount
{

    public class TemplateViewModel
    {
        public string? TemplateName { get; set; }
        public float? Price { get; set; }
        public IFormFile? ImgHoz { get; set; }
        public IFormFile? ImgVer { get; set; }

        public float? Discount { get; set; }

    }

}
