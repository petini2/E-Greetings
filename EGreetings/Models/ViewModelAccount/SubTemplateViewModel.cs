namespace EGreetings.Models.ViewModelAccount
{
    public class SubTemplateViewModel
    {
        public List<TemplateInfo> Templates { get; set; }
    }

    public class TemplateInfo
    {
        public string TemplateName { get; set; }
        public string ImgVer { get; set; }
    }

}
