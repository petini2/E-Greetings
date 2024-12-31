
namespace EGreetings.Data.Seeder
{
    using EGreetings.Models;
    using System;
    using System.Linq;
    public class TemplateSeeder
    {


        public static void SeedTemplate(EGreetingsDbContext context)
        {
            // Kiểm tra xem bảng Templates đã có dữ liệu chưa
            if (!context.Templates.Any())
            {
                // Thêm các template mẫu
                var templates = new[]
                {
                    new Template
{
TemplateName = "A day of love",
CategoryID =11,
Description = "Great Vibes, Fraunces, Alex Brush",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D1I.png",
ImgHoz = "WD-Vintage-D1S.svg",
SvgVer = "WD-Vintage-N1S.svg",
SvgHoz = "WD-Vintage-N1S.svg"
},
new Template
{
TemplateName = "Vintage White Rose",
CategoryID =11,
Description = "Eyesome Script, Cinzel Decorative",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D2I.png",
ImgHoz = "WD-Vintage-D2S.svg",
SvgVer = "WD-Vintage-N2S.svg",
SvgHoz = "WD-Vintage-N2S.svg"
},
new Template
{
TemplateName = "Lavi en rose",
CategoryID =11,
Description = "Fraunces",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D3I.png",
ImgHoz = "WD-Vintage-D3S.svg",
SvgVer = "WD-Vintage-N3S.svg",
SvgHoz = "WD-Vintage-N3S.svg"
},
new Template
{
TemplateName = "Flower Welcome You",
CategoryID =11,
Description = "Fraunces",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D4I.png",
ImgHoz = "WD-Vintage-D4S.svg",
SvgVer = "WD-Vintage-N4S.svg",
SvgHoz = "WD-Vintage-N4S.svg"
},
new Template
{
TemplateName = "Lily",
CategoryID =11,
Description = "Noto Serif",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D5I.png",
ImgHoz = "WD-Vintage-D5S.svg",
SvgVer = "WD-Vintage-N5S.svg",
SvgHoz = "WD-Vintage-N5S.svg"
},
new Template
{
TemplateName = "I Love You",
CategoryID =11,
Description = "Fraunces",
Price = (float)3,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D6I.png",
ImgHoz = "WD-Vintage-D6S.svg",
SvgVer = "WD-Vintage-N6S.svg",
SvgHoz = "WD-Vintage-N6S.svg"
},
new Template
{
TemplateName = "Love Behind",
CategoryID =11,
Description = "Citadel Script, Fraunces",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D7I.png",
ImgHoz = "WD-Vintage-D7S.svg",
SvgVer = "WD-Vintage-N7S.svg",
SvgHoz = "WD-Vintage-N7S.svg"
},
new Template
{
TemplateName = "Vintage Flower",
CategoryID =11,
Description = "Buongiorno Rastellino",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D8I.png",
ImgHoz = "WD-Vintage-D8S.svg",
SvgVer = "WD-Vintage-N8S.svg",
SvgHoz = "WD-Vintage-N8S.svg"
},
new Template
{
TemplateName = "Vintage Paper",
CategoryID =11,
Description = "Le jour script",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D9I.png",
ImgHoz = "WD-Vintage-D9S.svg",
SvgVer = "WD-Vintage-N9S.svg",
SvgHoz = "WD-Vintage-N9S.svg"
},
new Template
{
TemplateName = "White Rose",
CategoryID =11,
Description = "Buongiorno Rastellino",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D10I.png",
ImgHoz = "WD-Vintage-D10S.svg",
SvgVer = "WD-Vintage-N10S.svg",
SvgHoz = "WD-Vintage-N10S.svg"
},
new Template
{
TemplateName = "Vintage White",
CategoryID =11,
Description = "Amoresa",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D11I.png",
ImgHoz = "WD-Vintage-D11S.svg",
SvgVer = "WD-Vintage-N11S.svg",
SvgHoz = "WD-Vintage-N11S.svg"
},
new Template
{
TemplateName = "Vintage White 2.0",
CategoryID =11,
Description = "Fraunces",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D12I.png",
ImgHoz = "WD-Vintage-D12S.svg",
SvgVer = "WD-Vintage-N12S.svg",
SvgHoz = "WD-Vintage-N12S.svg"
},
new Template
{
TemplateName = "Vintage Yellow",
CategoryID =11,
Description = "Le jour script",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D13I.png",
ImgHoz = "WD-Vintage-D13S.svg",
SvgVer = "WD-Vintage-N13S.svg",
SvgHoz = "WD-Vintage-N13S.svg"
},
new Template
{
TemplateName = "More Flower",
CategoryID =11,
Description = "Fraunces",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D14I.png",
ImgHoz = "WD-Vintage-D14S.svg",
SvgVer = "WD-Vintage-N14S.svg",
SvgHoz = "WD-Vintage-N14S.svg"
},
new Template
{
TemplateName = "Flower Surrounded",
CategoryID =11,
Description = "Amoresa",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D15I.png",
ImgHoz = "WD-Vintage-D15S.svg",
SvgVer = "WD-Vintage-N15S.svg",
SvgHoz = "WD-Vintage-N15S.svg"
},
new Template
{
TemplateName = "Vintage Retro",
CategoryID =11,
Description = "Fraunces",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D16I.png",
ImgHoz = "WD-Vintage-D16S.svg",
SvgVer = "WD-Vintage-N16S.svg",
SvgHoz = "WD-Vintage-N16S.svg"
},
new Template
{
TemplateName = "Vintage Orange",
CategoryID =11,
Description = "Amsterdam One",
Price = (float)1.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D17I.png",
ImgHoz = "WD-Vintage-D17S.svg",
SvgVer = "WD-Vintage-N17S.svg",
SvgHoz = "WD-Vintage-N17S.svg"
},
new Template
{
TemplateName = "Vintage Light Puple",
CategoryID =11,
Description = "Disruptors Script",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Vintage-D18I.png",
ImgHoz = "WD-Vintage-D18S.svg",
SvgVer = "WD-Vintage-N18S.svg",
SvgHoz = "WD-Vintage-N18S.svg"
},
new Template
{
TemplateName = "Garden Love",
CategoryID =12,
Description = "Citadel Script, Fraunces",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D1I.png",
ImgHoz = "WD-Indoor-D1S.svg",
SvgVer = "WD-Indoor-N1S.svg",
SvgHoz = "WD-Indoor-N1S.svg"
},
new Template
{
TemplateName = "Church",
CategoryID =12,
Description = "Alice, Herr Von Muellerhoff",
Price = (float)2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D2I.png",
ImgHoz = "WD-Indoor-D2S.svg",
SvgVer = "WD-Indoor-N2S.svg",
SvgHoz = "WD-Indoor-N2S.svg"
},
new Template
{
TemplateName = "Girl Love Girl",
CategoryID =12,
Description = "Fraunces",
Price = (float)2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D3I.png",
ImgHoz = "WD-Indoor-D3S.svg",
SvgVer = "WD-Indoor-N3S.svg",
SvgHoz = "WD-Indoor-N3S.svg"
},
new Template
{
TemplateName = "Villa 1.0",
CategoryID =12,
Description = "Mistruly, Fraunces",
Price = (float)6,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D4I.png",
ImgHoz = "WD-Indoor-D4S.svg",
SvgVer = "WD-Indoor-N4S.svg",
SvgHoz = "WD-Indoor-N4S.svg"
},
new Template
{
TemplateName = "Villa 2.0",
CategoryID =12,
Description = "Mistruly, Bodoni FLF",
Price = (float)5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D5I.png",
ImgHoz = "WD-Indoor-D5S.svg",
SvgVer = "WD-Indoor-N5S.svg",
SvgHoz = "WD-Indoor-N5S.svg"
},
new Template
{
TemplateName = "Green Love",
CategoryID =12,
Description = "Sloop Script Pro",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D6I.png",
ImgHoz = "WD-Indoor-D6S.svg",
SvgVer = "WD-Indoor-N6S.svg",
SvgHoz = "WD-Indoor-N6S.svg"
},
new Template
{
TemplateName = "The Divine Beauty of Love",
CategoryID =12,
Description = "Citadel Script, Fraunces",
Price = (float)3,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D7I.png",
ImgHoz = "WD-Indoor-D7S.svg",
SvgVer = "WD-Indoor-N7S.svg",
SvgHoz = "WD-Indoor-N7S.svg"
},
new Template
{
TemplateName = "Autumn Leaves Road",
CategoryID =12,
Description = "Binggo Wood",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D8I.png",
ImgHoz = "WD-Indoor-D8S.svg",
SvgVer = "WD-Indoor-N8S.svg",
SvgHoz = "WD-Indoor-N8S.svg"
},
new Template
{
TemplateName = "Light Yellow",
CategoryID =12,
Description = "Daydream",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D9I.png",
ImgHoz = "WD-Indoor-D9S.svg",
SvgVer = "WD-Indoor-N9S.svg",
SvgHoz = "WD-Indoor-N9S.svg"
},
new Template
{
TemplateName = "Love Just Love ",
CategoryID =12,
Description = "Le jour script",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Indoor-D10I.png",
ImgHoz = "WD-Indoor-D10S.svg",
SvgVer = "WD-Indoor-N10S.svg",
SvgHoz = "WD-Indoor-N10S.svg"
},
new Template
{
TemplateName = "Snow",
CategoryID =13,
Description = "Angella White",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D1I.png",
ImgHoz = "WD-Outdoor-D1S.svg",
SvgVer = "WD-Outdoor-N1S.svg",
SvgHoz = "WD-Outdoor-N1S.svg"
},
new Template
{
TemplateName = "Love Under The Sunshine",
CategoryID =13,
Description = "Pinyon Script",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D2I.png",
ImgHoz = "WD-Outdoor-D2S.svg",
SvgVer = "WD-Outdoor-N2S.svg",
SvgHoz = "WD-Outdoor-N2S.svg"
},
new Template
{
TemplateName = "Autumn Sunshine",
CategoryID =13,
Description = "Fraunces",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D3I.png",
ImgHoz = "WD-Outdoor-D3S.svg",
SvgVer = "WD-Outdoor-N3S.svg",
SvgHoz = "WD-Outdoor-N3S.svg"
},
new Template
{
TemplateName = "Forest 1.0",
CategoryID =13,
Description = "Cinzel Decorative",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D4I.png",
ImgHoz = "WD-Outdoor-D4S.svg",
SvgVer = "WD-Outdoor-N4S.svg",
SvgHoz = "WD-Outdoor-N4S.svg"
},
new Template
{
TemplateName = "Dreamy",
CategoryID =13,
Description = "Fraunces",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D5I.png",
ImgHoz = "WD-Outdoor-D5S.svg",
SvgVer = "WD-Outdoor-N5S.svg",
SvgHoz = "WD-Outdoor-N5S.svg"
},
new Template
{
TemplateName = "Beach 1.0",
CategoryID =13,
Description = "Aniyah",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D6I.png",
ImgHoz = "WD-Outdoor-D6S.svg",
SvgVer = "WD-Outdoor-N6S.svg",
SvgHoz = "WD-Outdoor-N6S.svg"
},
new Template
{
TemplateName = "Beach 2.0",
CategoryID =13,
Description = "Aniyah",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D7I.png",
ImgHoz = "WD-Outdoor-D7S.svg",
SvgVer = "WD-Outdoor-N7S.svg",
SvgHoz = "WD-Outdoor-N7S.svg"
},
new Template
{
TemplateName = "Beach 3.0",
CategoryID =13,
Description = "Fraunces",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D8I.png",
ImgHoz = "WD-Outdoor-D8S.svg",
SvgVer = "WD-Outdoor-N8S.svg",
SvgHoz = "WD-Outdoor-N8S.svg"
},
new Template
{
TemplateName = "Beach 4.0",
CategoryID =13,
Description = "Aniyah",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D9I.png",
ImgHoz = "WD-Outdoor-D9S.svg",
SvgVer = "WD-Outdoor-N9S.svg",
SvgHoz = "WD-Outdoor-N9S.svg"
},
new Template
{
TemplateName = "Beach 5.0",
CategoryID =13,
Description = "Mistrully",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D10I.png",
ImgHoz = "WD-Outdoor-D10S.svg",
SvgVer = "WD-Outdoor-N10S.svg",
SvgHoz = "WD-Outdoor-N10S.svg"
},
new Template
{
TemplateName = "Mountan",
CategoryID =13,
Description = "Amsterdam One",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D11I.png",
ImgHoz = "WD-Outdoor-D11S.svg",
SvgVer = "WD-Outdoor-N11S.svg",
SvgHoz = "WD-Outdoor-N11S.svg"
},
new Template
{
TemplateName = "Pine Forrest 1.0",
CategoryID =13,
Description = "Amsterdam Four",
Price = (float)5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D12I.png",
ImgHoz = "WD-Outdoor-D12S.svg",
SvgVer = "WD-Outdoor-N12S.svg",
SvgHoz = "WD-Outdoor-N12S.svg"
},
new Template
{
TemplateName = "Pine Forrest 2.0",
CategoryID =13,
Description = "Amsterdam Four",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D13I.png",
ImgHoz = "WD-Outdoor-D13S.svg",
SvgVer = "WD-Outdoor-N13S.svg",
SvgHoz = "WD-Outdoor-N13S.svg"
},
new Template
{
TemplateName = "Pine Forrest 3.0",
CategoryID =13,
Description = "Mistrully",
Price = (float)0.9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D14I.png",
ImgHoz = "WD-Outdoor-D14S.svg",
SvgVer = "WD-Outdoor-N14S.svg",
SvgHoz = "WD-Outdoor-N14S.svg"
},
new Template
{
TemplateName = "Forest 2.0",
CategoryID =13,
Description = "Mistrully",
Price = (float)0.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D15I.png",
ImgHoz = "WD-Outdoor-D15S.svg",
SvgVer = "WD-Outdoor-N15S.svg",
SvgHoz = "WD-Outdoor-N15S.svg"
},
new Template
{
TemplateName = "Golden on Forrest",
CategoryID =13,
Description = "Amsterdam One",
Price = (float)4.5,
Discount = (float)3,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Outdoor-D16I.png",
ImgHoz = "WD-Outdoor-D16S.svg",
SvgVer = "WD-Outdoor-N16S.svg",
SvgHoz = "WD-Outdoor-N16S.svg"
},
new Template
{
TemplateName = "European Dispatch",
CategoryID =14,
Description = "Pinyon Script",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D1I.png",
ImgHoz = "WD-European Style-D1I.svg",
SvgVer = "WD-European Style-N1I.svg",
SvgHoz = "WD-European Style-N1I.svg"
},
new Template
{
TemplateName = "Classic Europe",
CategoryID =14,
Description = "Beauty Salon Script",
Price = (float)8,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D2I.png",
ImgHoz = "WD-European Style-D2I.svg",
SvgVer = "WD-European Style-N2I.svg",
SvgHoz = "WD-European Style-N2I.svg"
},
new Template
{
TemplateName = "Black & White",
CategoryID =14,
Description = "Playfair Display",
Price = (float)3,
Discount = (float)2.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D3I.png",
ImgHoz = "WD-European Style-D3I.svg",
SvgVer = "WD-European Style-N3I.svg",
SvgHoz = "WD-European Style-N3I.svg"
},
new Template
{
TemplateName = "Snow Forrest",
CategoryID =14,
Description = "Buongiorno Rastellino",
Price = (float)6,
Discount = (float)5.2,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D4I.png",
ImgHoz = "WD-European Style-D4I.svg",
SvgVer = "WD-European Style-N4I.svg",
SvgHoz = "WD-European Style-N4I.svg"
},
new Template
{
TemplateName = "Fairy Tale",
CategoryID =14,
Description = "Alex Brush",
Price = (float)8,
Discount = (float)7,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D5I.png",
ImgHoz = "WD-European Style-D5I.svg",
SvgVer = "WD-European Style-N5I.svg",
SvgHoz = "WD-European Style-N5I.svg"
},
new Template
{
TemplateName = "Classiquement beau",
CategoryID =14,
Description = "EFCO Brookshire",
Price = (float)7.5,
Discount = (float)9,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D6I.png",
ImgHoz = "WD-European Style-D6I.svg",
SvgVer = "WD-European Style-N6I.svg",
SvgHoz = "WD-European Style-N6I.svg"
},
new Template
{
TemplateName = "European Paper",
CategoryID =14,
Description = "Fry's Baskerville",
Price = (float)2.5,
Discount = (float)2.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D7I.png",
ImgHoz = "WD-European Style-D7I.svg",
SvgVer = "WD-European Style-N7I.svg",
SvgHoz = "WD-European Style-N7I.svg"
},
new Template
{
TemplateName = "Fleurs tombantes",
CategoryID =14,
Description = "Quattrocento",
Price = (float)6.5,
Discount = (float)2.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D8I.png",
ImgHoz = "WD-European Style-D8I.svg",
SvgVer = "WD-European Style-N8I.svg",
SvgHoz = "WD-European Style-N8I.svg"
},
new Template
{
TemplateName = "Vieille rue",
CategoryID =14,
Description = "Tan mon Cheri",
Price = (float)3,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D9I.png",
ImgHoz = "WD-European Style-D9I.svg",
SvgVer = "WD-European Style-N9I.svg",
SvgHoz = "WD-European Style-N9I.svg"
},
new Template
{
TemplateName = "Old Town",
CategoryID =14,
Description = "The Youngest Serif",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D10I.png",
ImgHoz = "WD-European Style-D10I.svg",
SvgVer = "WD-European Style-N10I.svg",
SvgHoz = "WD-European Style-N10I.svg"
},
new Template
{
TemplateName = "Le chemin du château",
CategoryID =14,
Description = "The Youngest ",
Price = (float)9,
Discount = (float)4.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D11I.png",
ImgHoz = "WD-European Style-D11I.svg",
SvgVer = "WD-European Style-N11I.svg",
SvgHoz = "WD-European Style-N11I.svg"
},
new Template
{
TemplateName = "Ancien",
CategoryID =14,
Description = "Themysion",
Price = (float)1.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D12I.png",
ImgHoz = "WD-European Style-D12I.svg",
SvgVer = "WD-European Style-N12I.svg",
SvgHoz = "WD-European Style-N12I.svg"
},
new Template
{
TemplateName = "I love you forever",
CategoryID =14,
Description = "Eyesome Script",
Price = (float)6,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D13I.png",
ImgHoz = "WD-European Style-D13I.svg",
SvgVer = "WD-European Style-N13I.svg",
SvgHoz = "WD-European Style-N13I.svg"
},
new Template
{
TemplateName = "Welcome To Our Love Story",
CategoryID =14,
Description = "Angella White",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D14I.png",
ImgHoz = "WD-European Style-D14I.svg",
SvgVer = "WD-European Style-N14I.svg",
SvgHoz = "WD-European Style-N14I.svg"
},
new Template
{
TemplateName = "Classic",
CategoryID =14,
Description = "Amoresa",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D15I.png",
ImgHoz = "WD-European Style-D15I.svg",
SvgVer = "WD-European Style-N15I.svg",
SvgHoz = "WD-European Style-N15I.svg"
},
new Template
{
TemplateName = "Golden In The Dark",
CategoryID =14,
Description = "Alex Brush",
Price = (float)7,
Discount = (float)2,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-European Style-D16I.png",
ImgHoz = "WD-European Style-D16I.svg",
SvgVer = "WD-European Style-N16I.svg",
SvgHoz = "WD-European Style-N16I.svg"
},
new Template
{
TemplateName = "Đám cưới cổ điển Việt Nam",
CategoryID =15,
Description = "Alex Brush, Dancing script",
Price = (float)6.5,
Discount = (float)5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D1I.png",
ImgHoz = "WD-Asian Style-D1I.svg",
SvgVer = "WD-Asian Style-N1I.svg",
SvgHoz = "WD-Asian Style-N1I.svg"
},
new Template
{
TemplateName = "India",
CategoryID =15,
Description = "Alex Brush, Bodoni FLF",
Price = (float)1.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D2I.png",
ImgHoz = "WD-Asian Style-D2I.svg",
SvgVer = "WD-Asian Style-N2I.svg",
SvgHoz = "WD-Asian Style-N2I.svg"
},
new Template
{
TemplateName = "Japan 1.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D3I.png",
ImgHoz = "WD-Asian Style-D3I.svg",
SvgVer = "WD-Asian Style-N3I.svg",
SvgHoz = "WD-Asian Style-N3I.svg"
},
new Template
{
TemplateName = "Korean 1.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D4I.png",
ImgHoz = "WD-Asian Style-D4I.svg",
SvgVer = "WD-Asian Style-N4I.svg",
SvgHoz = "WD-Asian Style-N4I.svg"
},
new Template
{
TemplateName = "China 1.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D5I.png",
ImgHoz = "WD-Asian Style-D5I.svg",
SvgVer = "WD-Asian Style-N5I.svg",
SvgHoz = "WD-Asian Style-N5I.svg"
},
new Template
{
TemplateName = "China 2.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D6I.png",
ImgHoz = "WD-Asian Style-D6I.svg",
SvgVer = "WD-Asian Style-N6I.svg",
SvgHoz = "WD-Asian Style-N6I.svg"
},
new Template
{
TemplateName = "China 3.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D7I.png",
ImgHoz = "WD-Asian Style-D7I.svg",
SvgVer = "WD-Asian Style-N7I.svg",
SvgHoz = "WD-Asian Style-N7I.svg"
},
new Template
{
TemplateName = "China 4.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D8I.png",
ImgHoz = "WD-Asian Style-D8I.svg",
SvgVer = "WD-Asian Style-N8I.svg",
SvgHoz = "WD-Asian Style-N8I.svg"
},
new Template
{
TemplateName = "China 5.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D9I.png",
ImgHoz = "WD-Asian Style-D9I.svg",
SvgVer = "WD-Asian Style-N9I.svg",
SvgHoz = "WD-Asian Style-N9I.svg"
},
new Template
{
TemplateName = "Đám cưới Long Phụng",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D10I.png",
ImgHoz = "WD-Asian Style-D10I.svg",
SvgVer = "WD-Asian Style-N10I.svg",
SvgHoz = "WD-Asian Style-N10I.svg"
},
new Template
{
TemplateName = "China 6.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D11I.png",
ImgHoz = "WD-Asian Style-D11I.svg",
SvgVer = "WD-Asian Style-N11I.svg",
SvgHoz = "WD-Asian Style-N11I.svg"
},
new Template
{
TemplateName = "Đám cưới Việt Nam hiện đại",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D12I.png",
ImgHoz = "WD-Asian Style-D12I.svg",
SvgVer = "WD-Asian Style-N12I.svg",
SvgHoz = "WD-Asian Style-N12I.svg"
},
new Template
{
TemplateName = "China 7.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D13I.png",
ImgHoz = "WD-Asian Style-D13I.svg",
SvgVer = "WD-Asian Style-N13I.svg",
SvgHoz = "WD-Asian Style-N13I.svg"
},
new Template
{
TemplateName = "China 8.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D14I.png",
ImgHoz = "WD-Asian Style-D14I.svg",
SvgVer = "WD-Asian Style-N14I.svg",
SvgHoz = "WD-Asian Style-N14I.svg"
},
new Template
{
TemplateName = "Japan 2.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D15I.png",
ImgHoz = "WD-Asian Style-D15I.svg",
SvgVer = "WD-Asian Style-N15I.svg",
SvgHoz = "WD-Asian Style-N15I.svg"
},
new Template
{
TemplateName = "Japan 3.0",
CategoryID =15,
Description = "",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Asian Style-D16I.png",
ImgHoz = "WD-Asian Style-D16I.svg",
SvgVer = "WD-Asian Style-N16I.svg",
SvgHoz = "WD-Asian Style-N16I.svg"
},
new Template
{
TemplateName = "Modern 1",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D1I.png",
ImgHoz = "WD-Modern-D1I.svg",
SvgVer = "WD-Modern-N1I.svg",
SvgHoz = "WD-Modern-N1I.svg"
},
new Template
{
TemplateName = "Modern 2",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D2I.png",
ImgHoz = "WD-Modern-D2I.svg",
SvgVer = "WD-Modern-N2I.svg",
SvgHoz = "WD-Modern-N2I.svg"
},
new Template
{
TemplateName = "Modern 3",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D3I.png",
ImgHoz = "WD-Modern-D3I.svg",
SvgVer = "WD-Modern-N3I.svg",
SvgHoz = "WD-Modern-N3I.svg"
},
new Template
{
TemplateName = "Modern 4",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D4I.png",
ImgHoz = "WD-Modern-D4I.svg",
SvgVer = "WD-Modern-N4I.svg",
SvgHoz = "WD-Modern-N4I.svg"
},
new Template
{
TemplateName = "Modern 5",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D5I.png",
ImgHoz = "WD-Modern-D5I.svg",
SvgVer = "WD-Modern-N5I.svg",
SvgHoz = "WD-Modern-N5I.svg"
},
new Template
{
TemplateName = "Modern 6",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D6I.png",
ImgHoz = "WD-Modern-D6I.svg",
SvgVer = "WD-Modern-N6I.svg",
SvgHoz = "WD-Modern-N6I.svg"
},
new Template
{
TemplateName = "Modern 7",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D7I.png",
ImgHoz = "WD-Modern-D7I.svg",
SvgVer = "WD-Modern-N7I.svg",
SvgHoz = "WD-Modern-N7I.svg"
},
new Template
{
TemplateName = "Modern 8",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D8I.png",
ImgHoz = "WD-Modern-D8I.svg",
SvgVer = "WD-Modern-N8I.svg",
SvgHoz = "WD-Modern-N8I.svg"
},
new Template
{
TemplateName = "Modern 9",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D9I.png",
ImgHoz = "WD-Modern-D9I.svg",
SvgVer = "WD-Modern-N9I.svg",
SvgHoz = "WD-Modern-N9I.svg"
},
new Template
{
TemplateName = "Modern 10",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D10I.png",
ImgHoz = "WD-Modern-D10I.svg",
SvgVer = "WD-Modern-N10I.svg",
SvgHoz = "WD-Modern-N10I.svg"
},
new Template
{
TemplateName = "Modern 11",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D11I.png",
ImgHoz = "WD-Modern-D11I.svg",
SvgVer = "WD-Modern-N11I.svg",
SvgHoz = "WD-Modern-N11I.svg"
},
new Template
{
TemplateName = "Modern 12",
CategoryID =16,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Modern-D12I.png",
ImgHoz = "WD-Modern-D12I.svg",
SvgVer = "WD-Modern-N12I.svg",
SvgHoz = "WD-Modern-N12I.svg"
},
new Template
{
TemplateName = "Classic 1",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D1I.png",
ImgHoz = "WD-Classic-D1I.svg",
SvgVer = "WD-Classic-N1I.svg",
SvgHoz = "WD-Classic-N1I.svg"
},
new Template
{
TemplateName = "Classic 2",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D2I.png",
ImgHoz = "WD-Classic-D2I.svg",
SvgVer = "WD-Classic-N2I.svg",
SvgHoz = "WD-Classic-N2I.svg"
},
new Template
{
TemplateName = "Classic 3",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D3I.png",
ImgHoz = "WD-Classic-D3I.svg",
SvgVer = "WD-Classic-N3I.svg",
SvgHoz = "WD-Classic-N3I.svg"
},
new Template
{
TemplateName = "Classic 4",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D4I.png",
ImgHoz = "WD-Classic-D4I.svg",
SvgVer = "WD-Classic-N4I.svg",
SvgHoz = "WD-Classic-N4I.svg"
},
new Template
{
TemplateName = "Classic 5",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D5I.png",
ImgHoz = "WD-Classic-D5I.svg",
SvgVer = "WD-Classic-N5I.svg",
SvgHoz = "WD-Classic-N5I.svg"
},
new Template
{
TemplateName = "Classic 6",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D6I.png",
ImgHoz = "WD-Classic-D6I.svg",
SvgVer = "WD-Classic-N6I.svg",
SvgHoz = "WD-Classic-N6I.svg"
},
new Template
{
TemplateName = "Classic 7",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D7I.png",
ImgHoz = "WD-Classic-D7I.svg",
SvgVer = "WD-Classic-N7I.svg",
SvgHoz = "WD-Classic-N7I.svg"
},
new Template
{
TemplateName = "Classic 8",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D8I.png",
ImgHoz = "WD-Classic-D8I.svg",
SvgVer = "WD-Classic-N8I.svg",
SvgHoz = "WD-Classic-N8I.svg"
},
new Template
{
TemplateName = "Classic 9",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D9I.png",
ImgHoz = "WD-Classic-D9I.svg",
SvgVer = "WD-Classic-N9I.svg",
SvgHoz = "WD-Classic-N9I.svg"
},
new Template
{
TemplateName = "Classic 10",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D10I.png",
ImgHoz = "WD-Classic-D10I.svg",
SvgVer = "WD-Classic-N10I.svg",
SvgHoz = "WD-Classic-N10I.svg"
},
new Template
{
TemplateName = "Classic 11",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D11I.png",
ImgHoz = "WD-Classic-D11I.svg",
SvgVer = "WD-Classic-N11I.svg",
SvgHoz = "WD-Classic-N11I.svg"
},
new Template
{
TemplateName = "Classic 12",
CategoryID =17,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-Classic-D12I.png",
ImgHoz = "WD-Classic-D12I.svg",
SvgVer = "WD-Classic-N12I.svg",
SvgHoz = "WD-Classic-N12I.svg"
},
new Template
{
TemplateName = "General 1",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D1I.png",
ImgHoz = "WD-General-D1I.svg",
SvgVer = "WD-General-N1I.svg",
SvgHoz = "WD-General-N1I.svg"
},
new Template
{
TemplateName = "General 2",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D2I.png",
ImgHoz = "WD-General-D2I.svg",
SvgVer = "WD-General-N2I.svg",
SvgHoz = "WD-General-N2I.svg"
},
new Template
{
TemplateName = "General 3",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D3I.png",
ImgHoz = "WD-General-D3I.svg",
SvgVer = "WD-General-N3I.svg",
SvgHoz = "WD-General-N3I.svg"
},
new Template
{
TemplateName = "General 4",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D4I.png",
ImgHoz = "WD-General-D4I.svg",
SvgVer = "WD-General-N4I.svg",
SvgHoz = "WD-General-N4I.svg"
},
new Template
{
TemplateName = "General 5",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D5I.png",
ImgHoz = "WD-General-D5I.svg",
SvgVer = "WD-General-N5I.svg",
SvgHoz = "WD-General-N5I.svg"
},
new Template
{
TemplateName = "General 6",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D6I.png",
ImgHoz = "WD-General-D6I.svg",
SvgVer = "WD-General-N6I.svg",
SvgHoz = "WD-General-N6I.svg"
},
new Template
{
TemplateName = "General 7",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D7I.png",
ImgHoz = "WD-General-D7I.svg",
SvgVer = "WD-General-N7I.svg",
SvgHoz = "WD-General-N7I.svg"
},
new Template
{
TemplateName = "General 8",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D8I.png",
ImgHoz = "WD-General-D8I.svg",
SvgVer = "WD-General-N8I.svg",
SvgHoz = "WD-General-N8I.svg"
},
new Template
{
TemplateName = "General 9",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D9I.png",
ImgHoz = "WD-General-D9I.svg",
SvgVer = "WD-General-N9I.svg",
SvgHoz = "WD-General-N9I.svg"
},
new Template
{
TemplateName = "General 10",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D10I.png",
ImgHoz = "WD-General-D10I.svg",
SvgVer = "WD-General-N10I.svg",
SvgHoz = "WD-General-N10I.svg"
},
new Template
{
TemplateName = "General 11",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D11I.png",
ImgHoz = "WD-General-D11I.svg",
SvgVer = "WD-General-N11I.svg",
SvgHoz = "WD-General-N11I.svg"
},
new Template
{
TemplateName = "General 12",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D12I.png",
ImgHoz = "WD-General-D12I.svg",
SvgVer = "WD-General-N12I.svg",
SvgHoz = "WD-General-N12I.svg"
},
new Template
{
TemplateName = "General 13",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D13I.png",
ImgHoz = "WD-General-D13I.svg",
SvgVer = "WD-General-N13I.svg",
SvgHoz = "WD-General-N13I.svg"
},
new Template
{
TemplateName = "General 14",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D14I.png",
ImgHoz = "WD-General-D14I.svg",
SvgVer = "WD-General-N14I.svg",
SvgHoz = "WD-General-N14I.svg"
},
new Template
{
TemplateName = "General 15",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D15I.png",
ImgHoz = "WD-General-D15I.svg",
SvgVer = "WD-General-N15I.svg",
SvgHoz = "WD-General-N15I.svg"
},
new Template
{
TemplateName = "General 16",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D16I.png",
ImgHoz = "WD-General-D16I.svg",
SvgVer = "WD-General-N16I.svg",
SvgHoz = "WD-General-N16I.svg"
},
new Template
{
TemplateName = "General 17",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D17I.png",
ImgHoz = "WD-General-D17I.svg",
SvgVer = "WD-General-N17I.svg",
SvgHoz = "WD-General-N17I.svg"
},
new Template
{
TemplateName = "General 18",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D18I.png",
ImgHoz = "WD-General-D18I.svg",
SvgVer = "WD-General-N18I.svg",
SvgHoz = "WD-General-N18I.svg"
},
new Template
{
TemplateName = "General 19",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D19I.png",
ImgHoz = "WD-General-D19I.svg",
SvgVer = "WD-General-N19I.svg",
SvgHoz = "WD-General-N19I.svg"
},
new Template
{
TemplateName = "General 20",
CategoryID =18,
Description = "",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "WD-General-D20I.png",
ImgHoz = "WD-General-D20I.svg",
SvgVer = "WD-General-N20I.svg",
SvgHoz = "WD-General-N20I.svg"
},
new Template
{
TemplateName = "Happy New Year 1",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D1I.png",
ImgHoz = "NY-New Year's Eve-D1S.svg",
SvgVer = "NY-New Year's Eve-N1S.svg",
SvgHoz = "NY-New Year's Eve-N1S.svg"
},
new Template
{
TemplateName = "Happy New Year 2",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D2I.png",
ImgHoz = "NY-New Year's Eve-D2S.svg",
SvgVer = "NY-New Year's Eve-N2S.svg",
SvgHoz = "NY-New Year's Eve-N2S.svg"
},
new Template
{
TemplateName = "Happy New Year 3",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D3I.png",
ImgHoz = "NY-New Year's Eve-D3S.svg",
SvgVer = "NY-New Year's Eve-N3S.svg",
SvgHoz = "NY-New Year's Eve-N3S.svg"
},
new Template
{
TemplateName = "Happy New Year 4",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D4I.png",
ImgHoz = "NY-New Year's Eve-D4S.svg",
SvgVer = "NY-New Year's Eve-N4S.svg",
SvgHoz = "NY-New Year's Eve-N4S.svg"
},
new Template
{
TemplateName = "Happy New Year 5",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D5I.png",
ImgHoz = "NY-New Year's Eve-D5S.svg",
SvgVer = "NY-New Year's Eve-N5S.svg",
SvgHoz = "NY-New Year's Eve-N5S.svg"
},
new Template
{
TemplateName = "Happy New Year 6",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D6I.png",
ImgHoz = "NY-New Year's Eve-D6S.svg",
SvgVer = "NY-New Year's Eve-N6S.svg",
SvgHoz = "NY-New Year's Eve-N6S.svg"
},
new Template
{
TemplateName = "Happy New Year 7",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D7I.png",
ImgHoz = "NY-New Year's Eve-D7S.svg",
SvgVer = "NY-New Year's Eve-N7S.svg",
SvgHoz = "NY-New Year's Eve-N7S.svg"
},
new Template
{
TemplateName = "Happy New Year 8",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D8I.png",
ImgHoz = "NY-New Year's Eve-D8S.svg",
SvgVer = "NY-New Year's Eve-N8S.svg",
SvgHoz = "NY-New Year's Eve-N8S.svg"
},
new Template
{
TemplateName = "Happy New Year 9",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D9I.png",
ImgHoz = "NY-New Year's Eve-D9S.svg",
SvgVer = "NY-New Year's Eve-N9S.svg",
SvgHoz = "NY-New Year's Eve-N9S.svg"
},
new Template
{
TemplateName = "Happy New Year 10",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D10I.png",
ImgHoz = "NY-New Year's Eve-D10S.svg",
SvgVer = "NY-New Year's Eve-N10S.svg",
SvgHoz = "NY-New Year's Eve-N10S.svg"
},
new Template
{
TemplateName = "Happy New Year 11",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D11I.png",
ImgHoz = "NY-New Year's Eve-D11S.svg",
SvgVer = "NY-New Year's Eve-N11S.svg",
SvgHoz = "NY-New Year's Eve-N11S.svg"
},
new Template
{
TemplateName = "Happy New Year 12",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D12I.png",
ImgHoz = "NY-New Year's Eve-D12S.svg",
SvgVer = "NY-New Year's Eve-N12S.svg",
SvgHoz = "NY-New Year's Eve-N12S.svg"
},
new Template
{
TemplateName = "Happy New Year 13",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D13I.png",
ImgHoz = "NY-New Year's Eve-D13S.svg",
SvgVer = "NY-New Year's Eve-N13S.svg",
SvgHoz = "NY-New Year's Eve-N13S.svg"
},
new Template
{
TemplateName = "Happy New Year 14",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D14I.png",
ImgHoz = "NY-New Year's Eve-D14S.svg",
SvgVer = "NY-New Year's Eve-N14S.svg",
SvgHoz = "NY-New Year's Eve-N14S.svg"
},
new Template
{
TemplateName = "Happy New Year 15",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D15I.png",
ImgHoz = "NY-New Year's Eve-D15S.svg",
SvgVer = "NY-New Year's Eve-N15S.svg",
SvgHoz = "NY-New Year's Eve-N15S.svg"
},
new Template
{
TemplateName = "Happy New Year 16",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D16I.png",
ImgHoz = "NY-New Year's Eve-D16S.svg",
SvgVer = "NY-New Year's Eve-N16S.svg",
SvgHoz = "NY-New Year's Eve-N16S.svg"
},
new Template
{
TemplateName = "Happy New Year 17",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D17I.png",
ImgHoz = "NY-New Year's Eve-D17S.svg",
SvgVer = "NY-New Year's Eve-N17S.svg",
SvgHoz = "NY-New Year's Eve-N17S.svg"
},
new Template
{
TemplateName = "Happy New Year 18",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D18I.png",
ImgHoz = "NY-New Year's Eve-D18S.svg",
SvgVer = "NY-New Year's Eve-N18S.svg",
SvgHoz = "NY-New Year's Eve-N18S.svg"
},
new Template
{
TemplateName = "Happy New Year 19",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D19I.png",
ImgHoz = "NY-New Year's Eve-D19S.svg",
SvgVer = "NY-New Year's Eve-N19S.svg",
SvgHoz = "NY-New Year's Eve-N19S.svg"
},
new Template
{
TemplateName = "Happy New Year 20",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D20I.png",
ImgHoz = "NY-New Year's Eve-D20S.svg",
SvgVer = "NY-New Year's Eve-N20S.svg",
SvgHoz = "NY-New Year's Eve-N20S.svg"
},
new Template
{
TemplateName = "Happy New Year 21",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D21I.png",
ImgHoz = "NY-New Year's Eve-D21S.svg",
SvgVer = "NY-New Year's Eve-N21S.svg",
SvgHoz = "NY-New Year's Eve-N21S.svg"
},
new Template
{
TemplateName = "Happy New Year 22",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D22I.png",
ImgHoz = "NY-New Year's Eve-D22S.svg",
SvgVer = "NY-New Year's Eve-N22S.svg",
SvgHoz = "NY-New Year's Eve-N22S.svg"
},
new Template
{
TemplateName = "Happy New Year 23",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D23I.png",
ImgHoz = "NY-New Year's Eve-D23S.svg",
SvgVer = "NY-New Year's Eve-N23S.svg",
SvgHoz = "NY-New Year's Eve-N23S.svg"
},
new Template
{
TemplateName = "Happy New Year 24",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D24I.png",
ImgHoz = "NY-New Year's Eve-D24S.svg",
SvgVer = "NY-New Year's Eve-N24S.svg",
SvgHoz = "NY-New Year's Eve-N24S.svg"
},
new Template
{
TemplateName = "Happy New Year 25",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D25I.png",
ImgHoz = "NY-New Year's Eve-D25S.svg",
SvgVer = "NY-New Year's Eve-N25S.svg",
SvgHoz = "NY-New Year's Eve-N25S.svg"
},
new Template
{
TemplateName = "Happy New Year 26",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D26I.png",
ImgHoz = "NY-New Year's Eve-D26S.svg",
SvgVer = "NY-New Year's Eve-N26S.svg",
SvgHoz = "NY-New Year's Eve-N26S.svg"
},
new Template
{
TemplateName = "Happy New Year 27",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D27I.png",
ImgHoz = "NY-New Year's Eve-D27S.svg",
SvgVer = "NY-New Year's Eve-N27S.svg",
SvgHoz = "NY-New Year's Eve-N27S.svg"
},
new Template
{
TemplateName = "Happy New Year 28",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D28I.png",
ImgHoz = "NY-New Year's Eve-D28S.svg",
SvgVer = "NY-New Year's Eve-N28S.svg",
SvgHoz = "NY-New Year's Eve-N28S.svg"
},
new Template
{
TemplateName = "Happy New Year 29",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D29I.png",
ImgHoz = "NY-New Year's Eve-D29S.svg",
SvgVer = "NY-New Year's Eve-N29S.svg",
SvgHoz = "NY-New Year's Eve-N29S.svg"
},
new Template
{
TemplateName = "Happy New Year 30",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D30I.png",
ImgHoz = "NY-New Year's Eve-D30S.svg",
SvgVer = "NY-New Year's Eve-N30S.svg",
SvgHoz = "NY-New Year's Eve-N30S.svg"
},
new Template
{
TemplateName = "Happy New Year 31",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D31I.png",
ImgHoz = "NY-New Year's Eve-D31S.svg",
SvgVer = "NY-New Year's Eve-N31S.svg",
SvgHoz = "NY-New Year's Eve-N31S.svg"
},
new Template
{
TemplateName = "Happy New Year 32",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D32I.png",
ImgHoz = "NY-New Year's Eve-D32S.svg",
SvgVer = "NY-New Year's Eve-N32S.svg",
SvgHoz = "NY-New Year's Eve-N32S.svg"
},
new Template
{
TemplateName = "Happy New Year 33",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D33I.png",
ImgHoz = "NY-New Year's Eve-D33S.svg",
SvgVer = "NY-New Year's Eve-N33S.svg",
SvgHoz = "NY-New Year's Eve-N33S.svg"
},
new Template
{
TemplateName = "Happy New Year 34",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D34I.png",
ImgHoz = "NY-New Year's Eve-D34S.svg",
SvgVer = "NY-New Year's Eve-N34S.svg",
SvgHoz = "NY-New Year's Eve-N34S.svg"
},
new Template
{
TemplateName = "Happy New Year 35",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D35I.png",
ImgHoz = "NY-New Year's Eve-D35S.svg",
SvgVer = "NY-New Year's Eve-N35S.svg",
SvgHoz = "NY-New Year's Eve-N35S.svg"
},
new Template
{
TemplateName = "Happy New Year 36",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D36I.png",
ImgHoz = "NY-New Year's Eve-D36S.svg",
SvgVer = "NY-New Year's Eve-N36S.svg",
SvgHoz = "NY-New Year's Eve-N36S.svg"
},
new Template
{
TemplateName = "Happy New Year 37",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D37I.png",
ImgHoz = "NY-New Year's Eve-D37S.svg",
SvgVer = "NY-New Year's Eve-N37S.svg",
SvgHoz = "NY-New Year's Eve-N37S.svg"
},
new Template
{
TemplateName = "Happy New Year 38",
CategoryID =19,
Description = "",
Price = (float)2.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-New Year's Eve-D38I.png",
ImgHoz = "NY-New Year's Eve-D38S.svg",
SvgVer = "NY-New Year's Eve-N38S.svg",
SvgHoz = "NY-New Year's Eve-N38S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 1",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D1I.png",
ImgHoz = "NY-Lunar New Year-D1S.svg",
SvgVer = "NY-Lunar New Year-N1S.svg",
SvgHoz = "NY-Lunar New Year-N1S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 2",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D2I.png",
ImgHoz = "NY-Lunar New Year-D2S.svg",
SvgVer = "NY-Lunar New Year-N2S.svg",
SvgHoz = "NY-Lunar New Year-N2S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 3",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D3I.png",
ImgHoz = "NY-Lunar New Year-D3S.svg",
SvgVer = "NY-Lunar New Year-N3S.svg",
SvgHoz = "NY-Lunar New Year-N3S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 4",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D4I.png",
ImgHoz = "NY-Lunar New Year-D4S.svg",
SvgVer = "NY-Lunar New Year-N4S.svg",
SvgHoz = "NY-Lunar New Year-N4S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 5",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D5I.png",
ImgHoz = "NY-Lunar New Year-D5S.svg",
SvgVer = "NY-Lunar New Year-N5S.svg",
SvgHoz = "NY-Lunar New Year-N5S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 6",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D6I.png",
ImgHoz = "NY-Lunar New Year-D6S.svg",
SvgVer = "NY-Lunar New Year-N6S.svg",
SvgHoz = "NY-Lunar New Year-N6S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 7",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D7I.png",
ImgHoz = "NY-Lunar New Year-D7S.svg",
SvgVer = "NY-Lunar New Year-N7S.svg",
SvgHoz = "NY-Lunar New Year-N7S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 8",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D8I.png",
ImgHoz = "NY-Lunar New Year-D8S.svg",
SvgVer = "NY-Lunar New Year-N8S.svg",
SvgHoz = "NY-Lunar New Year-N8S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 9",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D9I.png",
ImgHoz = "NY-Lunar New Year-D9S.svg",
SvgVer = "NY-Lunar New Year-N9S.svg",
SvgHoz = "NY-Lunar New Year-N9S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 10",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D10I.png",
ImgHoz = "NY-Lunar New Year-D10S.svg",
SvgVer = "NY-Lunar New Year-N10S.svg",
SvgHoz = "NY-Lunar New Year-N10S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 11",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D11I.png",
ImgHoz = "NY-Lunar New Year-D11S.svg",
SvgVer = "NY-Lunar New Year-N11S.svg",
SvgHoz = "NY-Lunar New Year-N11S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 12",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D12I.png",
ImgHoz = "NY-Lunar New Year-D12S.svg",
SvgVer = "NY-Lunar New Year-N12S.svg",
SvgHoz = "NY-Lunar New Year-N12S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 13",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D13I.png",
ImgHoz = "NY-Lunar New Year-D13S.svg",
SvgVer = "NY-Lunar New Year-N13S.svg",
SvgHoz = "NY-Lunar New Year-N13S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 14",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D14I.png",
ImgHoz = "NY-Lunar New Year-D14S.svg",
SvgVer = "NY-Lunar New Year-N14S.svg",
SvgHoz = "NY-Lunar New Year-N14S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 15",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D15I.png",
ImgHoz = "NY-Lunar New Year-D15S.svg",
SvgVer = "NY-Lunar New Year-N15S.svg",
SvgHoz = "NY-Lunar New Year-N15S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 16",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D16I.png",
ImgHoz = "NY-Lunar New Year-D16S.svg",
SvgVer = "NY-Lunar New Year-N16S.svg",
SvgHoz = "NY-Lunar New Year-N16S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 17",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D17I.png",
ImgHoz = "NY-Lunar New Year-D17S.svg",
SvgVer = "NY-Lunar New Year-N17S.svg",
SvgHoz = "NY-Lunar New Year-N17S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 18",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D18I.png",
ImgHoz = "NY-Lunar New Year-D18S.svg",
SvgVer = "NY-Lunar New Year-N18S.svg",
SvgHoz = "NY-Lunar New Year-N18S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 19",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D19I.png",
ImgHoz = "NY-Lunar New Year-D19S.svg",
SvgVer = "NY-Lunar New Year-N19S.svg",
SvgHoz = "NY-Lunar New Year-N19S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 20",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D20I.png",
ImgHoz = "NY-Lunar New Year-D20S.svg",
SvgVer = "NY-Lunar New Year-N20S.svg",
SvgHoz = "NY-Lunar New Year-N20S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 21",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D21I.png",
ImgHoz = "NY-Lunar New Year-D21S.svg",
SvgVer = "NY-Lunar New Year-N21S.svg",
SvgHoz = "NY-Lunar New Year-N21S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 22",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D22I.png",
ImgHoz = "NY-Lunar New Year-D22S.svg",
SvgVer = "NY-Lunar New Year-N22S.svg",
SvgHoz = "NY-Lunar New Year-N22S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 23",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D23I.png",
ImgHoz = "NY-Lunar New Year-D23S.svg",
SvgVer = "NY-Lunar New Year-N23S.svg",
SvgHoz = "NY-Lunar New Year-N23S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 24",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D24I.png",
ImgHoz = "NY-Lunar New Year-D24S.svg",
SvgVer = "NY-Lunar New Year-N24S.svg",
SvgHoz = "NY-Lunar New Year-N24S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 25",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D25I.png",
ImgHoz = "NY-Lunar New Year-D25S.svg",
SvgVer = "NY-Lunar New Year-N25S.svg",
SvgHoz = "NY-Lunar New Year-N25S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 26",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D26I.png",
ImgHoz = "NY-Lunar New Year-D26S.svg",
SvgVer = "NY-Lunar New Year-N26S.svg",
SvgHoz = "NY-Lunar New Year-N26S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 27",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D27I.png",
ImgHoz = "NY-Lunar New Year-D27S.svg",
SvgVer = "NY-Lunar New Year-N27S.svg",
SvgHoz = "NY-Lunar New Year-N27S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 28",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D28I.png",
ImgHoz = "NY-Lunar New Year-D28S.svg",
SvgVer = "NY-Lunar New Year-N28S.svg",
SvgHoz = "NY-Lunar New Year-N28S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 29",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D29I.png",
ImgHoz = "NY-Lunar New Year-D29S.svg",
SvgVer = "NY-Lunar New Year-N29S.svg",
SvgHoz = "NY-Lunar New Year-N29S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 30",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D30I.png",
ImgHoz = "NY-Lunar New Year-D30S.svg",
SvgVer = "NY-Lunar New Year-N30S.svg",
SvgHoz = "NY-Lunar New Year-N30S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 31",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D31I.png",
ImgHoz = "NY-Lunar New Year-D31S.svg",
SvgVer = "NY-Lunar New Year-N31S.svg",
SvgHoz = "NY-Lunar New Year-N31S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 32",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D32I.png",
ImgHoz = "NY-Lunar New Year-D32S.svg",
SvgVer = "NY-Lunar New Year-N32S.svg",
SvgHoz = "NY-Lunar New Year-N32S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 33",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D33I.png",
ImgHoz = "NY-Lunar New Year-D33S.svg",
SvgVer = "NY-Lunar New Year-N33S.svg",
SvgHoz = "NY-Lunar New Year-N33S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 34",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D34I.png",
ImgHoz = "NY-Lunar New Year-D34S.svg",
SvgVer = "NY-Lunar New Year-N34S.svg",
SvgHoz = "NY-Lunar New Year-N34S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 35",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D35I.png",
ImgHoz = "NY-Lunar New Year-D35S.svg",
SvgVer = "NY-Lunar New Year-N35S.svg",
SvgHoz = "NY-Lunar New Year-N35S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 36",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D36I.png",
ImgHoz = "NY-Lunar New Year-D36S.svg",
SvgVer = "NY-Lunar New Year-N36S.svg",
SvgHoz = "NY-Lunar New Year-N36S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 37",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D37I.png",
ImgHoz = "NY-Lunar New Year-D37S.svg",
SvgVer = "NY-Lunar New Year-N37S.svg",
SvgHoz = "NY-Lunar New Year-N37S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 38",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D38I.png",
ImgHoz = "NY-Lunar New Year-D38S.svg",
SvgVer = "NY-Lunar New Year-N38S.svg",
SvgHoz = "NY-Lunar New Year-N38S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 39",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D39I.png",
ImgHoz = "NY-Lunar New Year-D39S.svg",
SvgVer = "NY-Lunar New Year-N39S.svg",
SvgHoz = "NY-Lunar New Year-N39S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 40",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D40I.png",
ImgHoz = "NY-Lunar New Year-D40S.svg",
SvgVer = "NY-Lunar New Year-N40S.svg",
SvgHoz = "NY-Lunar New Year-N40S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 41",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D41I.png",
ImgHoz = "NY-Lunar New Year-D41S.svg",
SvgVer = "NY-Lunar New Year-N41S.svg",
SvgHoz = "NY-Lunar New Year-N41S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 42",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D42I.png",
ImgHoz = "NY-Lunar New Year-D42S.svg",
SvgVer = "NY-Lunar New Year-N42S.svg",
SvgHoz = "NY-Lunar New Year-N42S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 43",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D43I.png",
ImgHoz = "NY-Lunar New Year-D43S.svg",
SvgVer = "NY-Lunar New Year-N43S.svg",
SvgHoz = "NY-Lunar New Year-N43S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 44",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D44I.png",
ImgHoz = "NY-Lunar New Year-D44S.svg",
SvgVer = "NY-Lunar New Year-N44S.svg",
SvgHoz = "NY-Lunar New Year-N44S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 45",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D45I.png",
ImgHoz = "NY-Lunar New Year-D45S.svg",
SvgVer = "NY-Lunar New Year-N45S.svg",
SvgHoz = "NY-Lunar New Year-N45S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 46",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D46I.png",
ImgHoz = "NY-Lunar New Year-D46S.svg",
SvgVer = "NY-Lunar New Year-N46S.svg",
SvgHoz = "NY-Lunar New Year-N46S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 47",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D47I.png",
ImgHoz = "NY-Lunar New Year-D47S.svg",
SvgVer = "NY-Lunar New Year-N47S.svg",
SvgHoz = "NY-Lunar New Year-N47S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 48",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D48I.png",
ImgHoz = "NY-Lunar New Year-D48S.svg",
SvgVer = "NY-Lunar New Year-N48S.svg",
SvgHoz = "NY-Lunar New Year-N48S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 49",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D49I.png",
ImgHoz = "NY-Lunar New Year-D49S.svg",
SvgVer = "NY-Lunar New Year-N49S.svg",
SvgHoz = "NY-Lunar New Year-N49S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 50",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D50I.png",
ImgHoz = "NY-Lunar New Year-D50S.svg",
SvgVer = "NY-Lunar New Year-N50S.svg",
SvgHoz = "NY-Lunar New Year-N50S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 51",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D51I.png",
ImgHoz = "NY-Lunar New Year-D51S.svg",
SvgVer = "NY-Lunar New Year-N51S.svg",
SvgHoz = "NY-Lunar New Year-N51S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 52",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D52I.png",
ImgHoz = "NY-Lunar New Year-D52S.svg",
SvgVer = "NY-Lunar New Year-N52S.svg",
SvgHoz = "NY-Lunar New Year-N52S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 53",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D53I.png",
ImgHoz = "NY-Lunar New Year-D53S.svg",
SvgVer = "NY-Lunar New Year-N53S.svg",
SvgHoz = "NY-Lunar New Year-N53S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 54",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D54I.png",
ImgHoz = "NY-Lunar New Year-D54S.svg",
SvgVer = "NY-Lunar New Year-N54S.svg",
SvgHoz = "NY-Lunar New Year-N54S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 55",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D55I.png",
ImgHoz = "NY-Lunar New Year-D55S.svg",
SvgVer = "NY-Lunar New Year-N55S.svg",
SvgHoz = "NY-Lunar New Year-N55S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 56",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D56I.png",
ImgHoz = "NY-Lunar New Year-D56S.svg",
SvgVer = "NY-Lunar New Year-N56S.svg",
SvgHoz = "NY-Lunar New Year-N56S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 57",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D57I.png",
ImgHoz = "NY-Lunar New Year-D57S.svg",
SvgVer = "NY-Lunar New Year-N57S.svg",
SvgHoz = "NY-Lunar New Year-N57S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 58",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D58I.png",
ImgHoz = "NY-Lunar New Year-D58S.svg",
SvgVer = "NY-Lunar New Year-N58S.svg",
SvgHoz = "NY-Lunar New Year-N58S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 59",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D59I.png",
ImgHoz = "NY-Lunar New Year-D59S.svg",
SvgVer = "NY-Lunar New Year-N59S.svg",
SvgHoz = "NY-Lunar New Year-N59S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 60",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D60I.png",
ImgHoz = "NY-Lunar New Year-D60S.svg",
SvgVer = "NY-Lunar New Year-N60S.svg",
SvgHoz = "NY-Lunar New Year-N60S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 61",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D61I.png",
ImgHoz = "NY-Lunar New Year-D61S.svg",
SvgVer = "NY-Lunar New Year-N61S.svg",
SvgHoz = "NY-Lunar New Year-N61S.svg"
},
new Template
{
TemplateName = "Happy Lunar New Year 62",
CategoryID =20,
Description = "",
Price = (float)7,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "NY-Lunar New Year-D62I.png",
ImgHoz = "NY-Lunar New Year-D62S.svg",
SvgVer = "NY-Lunar New Year-N62S.svg",
SvgHoz = "NY-Lunar New Year-N62S.svg"
},
new Template
{
TemplateName = "Happy Valentine 1",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D1I.png",
ImgHoz = "LV-Valentine-D1S.svg",
SvgVer = "LV-Valentine-N1S.svg",
SvgHoz = "LV-Valentine-N1S.svg"
},
new Template
{
TemplateName = "Happy Valentine 2",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D2I.png",
ImgHoz = "LV-Valentine-D2S.svg",
SvgVer = "LV-Valentine-N2S.svg",
SvgHoz = "LV-Valentine-N2S.svg"
},
new Template
{
TemplateName = "Happy Valentine 3",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D3I.png",
ImgHoz = "LV-Valentine-D3S.svg",
SvgVer = "LV-Valentine-N3S.svg",
SvgHoz = "LV-Valentine-N3S.svg"
},
new Template
{
TemplateName = "Happy Valentine 4",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D4I.png",
ImgHoz = "LV-Valentine-D4S.svg",
SvgVer = "LV-Valentine-N4S.svg",
SvgHoz = "LV-Valentine-N4S.svg"
},
new Template
{
TemplateName = "Happy Valentine 5",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D5I.png",
ImgHoz = "LV-Valentine-D5S.svg",
SvgVer = "LV-Valentine-N5S.svg",
SvgHoz = "LV-Valentine-N5S.svg"
},
new Template
{
TemplateName = "Happy Valentine 6",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D6I.png",
ImgHoz = "LV-Valentine-D6S.svg",
SvgVer = "LV-Valentine-N6S.svg",
SvgHoz = "LV-Valentine-N6S.svg"
},
new Template
{
TemplateName = "Happy Valentine 7",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D7I.png",
ImgHoz = "LV-Valentine-D7S.svg",
SvgVer = "LV-Valentine-N7S.svg",
SvgHoz = "LV-Valentine-N7S.svg"
},
new Template
{
TemplateName = "Happy Valentine 8",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D8I.png",
ImgHoz = "LV-Valentine-D8S.svg",
SvgVer = "LV-Valentine-N8S.svg",
SvgHoz = "LV-Valentine-N8S.svg"
},
new Template
{
TemplateName = "Happy Valentine 9",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D9I.png",
ImgHoz = "LV-Valentine-D9S.svg",
SvgVer = "LV-Valentine-N9S.svg",
SvgHoz = "LV-Valentine-N9S.svg"
},
new Template
{
TemplateName = "Happy Valentine 10",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D10I.png",
ImgHoz = "LV-Valentine-D10S.svg",
SvgVer = "LV-Valentine-N10S.svg",
SvgHoz = "LV-Valentine-N10S.svg"
},
new Template
{
TemplateName = "Happy Valentine 11",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D11I.png",
ImgHoz = "LV-Valentine-D11S.svg",
SvgVer = "LV-Valentine-N11S.svg",
SvgHoz = "LV-Valentine-N11S.svg"
},
new Template
{
TemplateName = "Happy Valentine 12",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D12I.png",
ImgHoz = "LV-Valentine-D12S.svg",
SvgVer = "LV-Valentine-N12S.svg",
SvgHoz = "LV-Valentine-N12S.svg"
},
new Template
{
TemplateName = "Happy Valentine 13",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D13I.png",
ImgHoz = "LV-Valentine-D13S.svg",
SvgVer = "LV-Valentine-N13S.svg",
SvgHoz = "LV-Valentine-N13S.svg"
},
new Template
{
TemplateName = "Happy Valentine 14",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D14I.png",
ImgHoz = "LV-Valentine-D14S.svg",
SvgVer = "LV-Valentine-N14S.svg",
SvgHoz = "LV-Valentine-N14S.svg"
},
new Template
{
TemplateName = "Happy Valentine 15",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D15I.png",
ImgHoz = "LV-Valentine-D15S.svg",
SvgVer = "LV-Valentine-N15S.svg",
SvgHoz = "LV-Valentine-N15S.svg"
},
new Template
{
TemplateName = "Happy Valentine 16",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D16I.png",
ImgHoz = "LV-Valentine-D16S.svg",
SvgVer = "LV-Valentine-N16S.svg",
SvgHoz = "LV-Valentine-N16S.svg"
},
new Template
{
TemplateName = "Happy Valentine 17",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D17I.png",
ImgHoz = "LV-Valentine-D17S.svg",
SvgVer = "LV-Valentine-N17S.svg",
SvgHoz = "LV-Valentine-N17S.svg"
},
new Template
{
TemplateName = "Happy Valentine 18",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D18I.png",
ImgHoz = "LV-Valentine-D18S.svg",
SvgVer = "LV-Valentine-N18S.svg",
SvgHoz = "LV-Valentine-N18S.svg"
},
new Template
{
TemplateName = "Happy Valentine 19",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D19I.png",
ImgHoz = "LV-Valentine-D19S.svg",
SvgVer = "LV-Valentine-N19S.svg",
SvgHoz = "LV-Valentine-N19S.svg"
},
new Template
{
TemplateName = "Happy Valentine 20",
CategoryID =21,
Description = "",
Price = (float)9,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Valentine-D20I.png",
ImgHoz = "LV-Valentine-D20S.svg",
SvgVer = "LV-Valentine-N20S.svg",
SvgHoz = "LV-Valentine-N20S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 1",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D1I.png",
ImgHoz = "LV-Qixi Festival-D1S.svg",
SvgVer = "LV-Qixi Festival-N1S.svg",
SvgHoz = "LV-Qixi Festival-N1S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 2",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D2I.png",
ImgHoz = "LV-Qixi Festival-D2S.svg",
SvgVer = "LV-Qixi Festival-N2S.svg",
SvgHoz = "LV-Qixi Festival-N2S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 3",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D3I.png",
ImgHoz = "LV-Qixi Festival-D3S.svg",
SvgVer = "LV-Qixi Festival-N3S.svg",
SvgHoz = "LV-Qixi Festival-N3S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 4",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D4I.png",
ImgHoz = "LV-Qixi Festival-D4S.svg",
SvgVer = "LV-Qixi Festival-N4S.svg",
SvgHoz = "LV-Qixi Festival-N4S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 5",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D5I.png",
ImgHoz = "LV-Qixi Festival-D5S.svg",
SvgVer = "LV-Qixi Festival-N5S.svg",
SvgHoz = "LV-Qixi Festival-N5S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 6",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D6I.png",
ImgHoz = "LV-Qixi Festival-D6S.svg",
SvgVer = "LV-Qixi Festival-N6S.svg",
SvgHoz = "LV-Qixi Festival-N6S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 7",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D7I.png",
ImgHoz = "LV-Qixi Festival-D7S.svg",
SvgVer = "LV-Qixi Festival-N7S.svg",
SvgHoz = "LV-Qixi Festival-N7S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 8",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D8I.png",
ImgHoz = "LV-Qixi Festival-D8S.svg",
SvgVer = "LV-Qixi Festival-N8S.svg",
SvgHoz = "LV-Qixi Festival-N8S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 9",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D9I.png",
ImgHoz = "LV-Qixi Festival-D9S.svg",
SvgVer = "LV-Qixi Festival-N9S.svg",
SvgHoz = "LV-Qixi Festival-N9S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 10",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D10I.png",
ImgHoz = "LV-Qixi Festival-D10S.svg",
SvgVer = "LV-Qixi Festival-N10S.svg",
SvgHoz = "LV-Qixi Festival-N10S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 11",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D11I.png",
ImgHoz = "LV-Qixi Festival-D11S.svg",
SvgVer = "LV-Qixi Festival-N11S.svg",
SvgHoz = "LV-Qixi Festival-N11S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 12",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D12I.png",
ImgHoz = "LV-Qixi Festival-D12S.svg",
SvgVer = "LV-Qixi Festival-N12S.svg",
SvgHoz = "LV-Qixi Festival-N12S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 13",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D13I.png",
ImgHoz = "LV-Qixi Festival-D13S.svg",
SvgVer = "LV-Qixi Festival-N13S.svg",
SvgHoz = "LV-Qixi Festival-N13S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 14",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D14I.png",
ImgHoz = "LV-Qixi Festival-D14S.svg",
SvgVer = "LV-Qixi Festival-N14S.svg",
SvgHoz = "LV-Qixi Festival-N14S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 15",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D15I.png",
ImgHoz = "LV-Qixi Festival-D15S.svg",
SvgVer = "LV-Qixi Festival-N15S.svg",
SvgHoz = "LV-Qixi Festival-N15S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 16",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D16I.png",
ImgHoz = "LV-Qixi Festival-D16S.svg",
SvgVer = "LV-Qixi Festival-N16S.svg",
SvgHoz = "LV-Qixi Festival-N16S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 17",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D17I.png",
ImgHoz = "LV-Qixi Festival-D17S.svg",
SvgVer = "LV-Qixi Festival-N17S.svg",
SvgHoz = "LV-Qixi Festival-N17S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 18",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D18I.png",
ImgHoz = "LV-Qixi Festival-D18S.svg",
SvgVer = "LV-Qixi Festival-N18S.svg",
SvgHoz = "LV-Qixi Festival-N18S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 19",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D19I.png",
ImgHoz = "LV-Qixi Festival-D19S.svg",
SvgVer = "LV-Qixi Festival-N19S.svg",
SvgHoz = "LV-Qixi Festival-N19S.svg"
},
new Template
{
TemplateName = "Qixi Festival - Thất tịch - 七夕节 20",
CategoryID =22,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Qixi Festival-D20I.png",
ImgHoz = "LV-Qixi Festival-D20S.svg",
SvgVer = "LV-Qixi Festival-N20S.svg",
SvgHoz = "LV-Qixi Festival-N20S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 1",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D1I.png",
ImgHoz = "LV-Mother's Day-D1S.svg",
SvgVer = "LV-Mother's Day-N1S.svg",
SvgHoz = "LV-Mother's Day-N1S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 2",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D2I.png",
ImgHoz = "LV-Mother's Day-D2S.svg",
SvgVer = "LV-Mother's Day-N2S.svg",
SvgHoz = "LV-Mother's Day-N2S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 3",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D3I.png",
ImgHoz = "LV-Mother's Day-D3S.svg",
SvgVer = "LV-Mother's Day-N3S.svg",
SvgHoz = "LV-Mother's Day-N3S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 4",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D4I.png",
ImgHoz = "LV-Mother's Day-D4S.svg",
SvgVer = "LV-Mother's Day-N4S.svg",
SvgHoz = "LV-Mother's Day-N4S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 5",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D5I.png",
ImgHoz = "LV-Mother's Day-D5S.svg",
SvgVer = "LV-Mother's Day-N5S.svg",
SvgHoz = "LV-Mother's Day-N5S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 6",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D6I.png",
ImgHoz = "LV-Mother's Day-D6S.svg",
SvgVer = "LV-Mother's Day-N6S.svg",
SvgHoz = "LV-Mother's Day-N6S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 7",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D7I.png",
ImgHoz = "LV-Mother's Day-D7S.svg",
SvgVer = "LV-Mother's Day-N7S.svg",
SvgHoz = "LV-Mother's Day-N7S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 8",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D8I.png",
ImgHoz = "LV-Mother's Day-D8S.svg",
SvgVer = "LV-Mother's Day-N8S.svg",
SvgHoz = "LV-Mother's Day-N8S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 9",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D9I.png",
ImgHoz = "LV-Mother's Day-D9S.svg",
SvgVer = "LV-Mother's Day-N9S.svg",
SvgHoz = "LV-Mother's Day-N9S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 10",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D10I.png",
ImgHoz = "LV-Mother's Day-D10S.svg",
SvgVer = "LV-Mother's Day-N10S.svg",
SvgHoz = "LV-Mother's Day-N10S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 11",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D11I.png",
ImgHoz = "LV-Mother's Day-D11S.svg",
SvgVer = "LV-Mother's Day-N11S.svg",
SvgHoz = "LV-Mother's Day-N11S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 12",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D12I.png",
ImgHoz = "LV-Mother's Day-D12S.svg",
SvgVer = "LV-Mother's Day-N12S.svg",
SvgHoz = "LV-Mother's Day-N12S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 13",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D13I.png",
ImgHoz = "LV-Mother's Day-D13S.svg",
SvgVer = "LV-Mother's Day-N13S.svg",
SvgHoz = "LV-Mother's Day-N13S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 14",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D14I.png",
ImgHoz = "LV-Mother's Day-D14S.svg",
SvgVer = "LV-Mother's Day-N14S.svg",
SvgHoz = "LV-Mother's Day-N14S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 15",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D15I.png",
ImgHoz = "LV-Mother's Day-D15S.svg",
SvgVer = "LV-Mother's Day-N15S.svg",
SvgHoz = "LV-Mother's Day-N15S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 16",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D16I.png",
ImgHoz = "LV-Mother's Day-D16S.svg",
SvgVer = "LV-Mother's Day-N16S.svg",
SvgHoz = "LV-Mother's Day-N16S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 17",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D17I.png",
ImgHoz = "LV-Mother's Day-D17S.svg",
SvgVer = "LV-Mother's Day-N17S.svg",
SvgHoz = "LV-Mother's Day-N17S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 18",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D18I.png",
ImgHoz = "LV-Mother's Day-D18S.svg",
SvgVer = "LV-Mother's Day-N18S.svg",
SvgHoz = "LV-Mother's Day-N18S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 19",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D19I.png",
ImgHoz = "LV-Mother's Day-D19S.svg",
SvgVer = "LV-Mother's Day-N19S.svg",
SvgHoz = "LV-Mother's Day-N19S.svg"
},
new Template
{
TemplateName = "Happy Mother's Day 20",
CategoryID =23,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Mother's Day-D20I.png",
ImgHoz = "LV-Mother's Day-D20S.svg",
SvgVer = "LV-Mother's Day-N20S.svg",
SvgHoz = "LV-Mother's Day-N20S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 1",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D1I.png",
ImgHoz = "LV-Father's Day-D1S.svg",
SvgVer = "LV-Father's Day-N1S.svg",
SvgHoz = "LV-Father's Day-N1S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 2",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D2I.png",
ImgHoz = "LV-Father's Day-D2S.svg",
SvgVer = "LV-Father's Day-N2S.svg",
SvgHoz = "LV-Father's Day-N2S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 3",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D3I.png",
ImgHoz = "LV-Father's Day-D3S.svg",
SvgVer = "LV-Father's Day-N3S.svg",
SvgHoz = "LV-Father's Day-N3S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 4",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D4I.png",
ImgHoz = "LV-Father's Day-D4S.svg",
SvgVer = "LV-Father's Day-N4S.svg",
SvgHoz = "LV-Father's Day-N4S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 5",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D5I.png",
ImgHoz = "LV-Father's Day-D5S.svg",
SvgVer = "LV-Father's Day-N5S.svg",
SvgHoz = "LV-Father's Day-N5S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 6",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D6I.png",
ImgHoz = "LV-Father's Day-D6S.svg",
SvgVer = "LV-Father's Day-N6S.svg",
SvgHoz = "LV-Father's Day-N6S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 7",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D7I.png",
ImgHoz = "LV-Father's Day-D7S.svg",
SvgVer = "LV-Father's Day-N7S.svg",
SvgHoz = "LV-Father's Day-N7S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 8",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D8I.png",
ImgHoz = "LV-Father's Day-D8S.svg",
SvgVer = "LV-Father's Day-N8S.svg",
SvgHoz = "LV-Father's Day-N8S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 9",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D9I.png",
ImgHoz = "LV-Father's Day-D9S.svg",
SvgVer = "LV-Father's Day-N9S.svg",
SvgHoz = "LV-Father's Day-N9S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 10",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D10I.png",
ImgHoz = "LV-Father's Day-D10S.svg",
SvgVer = "LV-Father's Day-N10S.svg",
SvgHoz = "LV-Father's Day-N10S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 11",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D11I.png",
ImgHoz = "LV-Father's Day-D11S.svg",
SvgVer = "LV-Father's Day-N11S.svg",
SvgHoz = "LV-Father's Day-N11S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 12",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D12I.png",
ImgHoz = "LV-Father's Day-D12S.svg",
SvgVer = "LV-Father's Day-N12S.svg",
SvgHoz = "LV-Father's Day-N12S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 13",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D13I.png",
ImgHoz = "LV-Father's Day-D13S.svg",
SvgVer = "LV-Father's Day-N13S.svg",
SvgHoz = "LV-Father's Day-N13S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 14",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D14I.png",
ImgHoz = "LV-Father's Day-D14S.svg",
SvgVer = "LV-Father's Day-N14S.svg",
SvgHoz = "LV-Father's Day-N14S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 15",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D15I.png",
ImgHoz = "LV-Father's Day-D15S.svg",
SvgVer = "LV-Father's Day-N15S.svg",
SvgHoz = "LV-Father's Day-N15S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 16",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D16I.png",
ImgHoz = "LV-Father's Day-D16S.svg",
SvgVer = "LV-Father's Day-N16S.svg",
SvgHoz = "LV-Father's Day-N16S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 17",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D17I.png",
ImgHoz = "LV-Father's Day-D17S.svg",
SvgVer = "LV-Father's Day-N17S.svg",
SvgHoz = "LV-Father's Day-N17S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 18",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D18I.png",
ImgHoz = "LV-Father's Day-D18S.svg",
SvgVer = "LV-Father's Day-N18S.svg",
SvgHoz = "LV-Father's Day-N18S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 19",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D19I.png",
ImgHoz = "LV-Father's Day-D19S.svg",
SvgVer = "LV-Father's Day-N19S.svg",
SvgHoz = "LV-Father's Day-N19S.svg"
},
new Template
{
TemplateName = "Happy Father's Day 20",
CategoryID =24,
Description = "",
Price = (float)1.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Father's Day-D20I.png",
ImgHoz = "LV-Father's Day-D20S.svg",
SvgVer = "LV-Father's Day-N20S.svg",
SvgHoz = "LV-Father's Day-N20S.svg"
},
new Template
{
TemplateName = "Thank you 1",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D1I.png",
ImgHoz = "LV-Thank You-D1S.svg",
SvgVer = "LV-Thank You-N1S.svg",
SvgHoz = "LV-Thank You-N1S.svg"
},
new Template
{
TemplateName = "Thank you 2",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D2I.png",
ImgHoz = "LV-Thank You-D2S.svg",
SvgVer = "LV-Thank You-N2S.svg",
SvgHoz = "LV-Thank You-N2S.svg"
},
new Template
{
TemplateName = "Thank you 3",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D3I.png",
ImgHoz = "LV-Thank You-D3S.svg",
SvgVer = "LV-Thank You-N3S.svg",
SvgHoz = "LV-Thank You-N3S.svg"
},
new Template
{
TemplateName = "Thank you 4",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D4I.png",
ImgHoz = "LV-Thank You-D4S.svg",
SvgVer = "LV-Thank You-N4S.svg",
SvgHoz = "LV-Thank You-N4S.svg"
},
new Template
{
TemplateName = "Thank you 5",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D5I.png",
ImgHoz = "LV-Thank You-D5S.svg",
SvgVer = "LV-Thank You-N5S.svg",
SvgHoz = "LV-Thank You-N5S.svg"
},
new Template
{
TemplateName = "Thank you 6",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D6I.png",
ImgHoz = "LV-Thank You-D6S.svg",
SvgVer = "LV-Thank You-N6S.svg",
SvgHoz = "LV-Thank You-N6S.svg"
},
new Template
{
TemplateName = "Thank you 7",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D7I.png",
ImgHoz = "LV-Thank You-D7S.svg",
SvgVer = "LV-Thank You-N7S.svg",
SvgHoz = "LV-Thank You-N7S.svg"
},
new Template
{
TemplateName = "Thank you 8",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D8I.png",
ImgHoz = "LV-Thank You-D8S.svg",
SvgVer = "LV-Thank You-N8S.svg",
SvgHoz = "LV-Thank You-N8S.svg"
},
new Template
{
TemplateName = "Thank you 9",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D9I.png",
ImgHoz = "LV-Thank You-D9S.svg",
SvgVer = "LV-Thank You-N9S.svg",
SvgHoz = "LV-Thank You-N9S.svg"
},
new Template
{
TemplateName = "Thank you 10",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D10I.png",
ImgHoz = "LV-Thank You-D10S.svg",
SvgVer = "LV-Thank You-N10S.svg",
SvgHoz = "LV-Thank You-N10S.svg"
},
new Template
{
TemplateName = "Thank you 11",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D11I.png",
ImgHoz = "LV-Thank You-D11S.svg",
SvgVer = "LV-Thank You-N11S.svg",
SvgHoz = "LV-Thank You-N11S.svg"
},
new Template
{
TemplateName = "Thank you 12",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D12I.png",
ImgHoz = "LV-Thank You-D12S.svg",
SvgVer = "LV-Thank You-N12S.svg",
SvgHoz = "LV-Thank You-N12S.svg"
},
new Template
{
TemplateName = "Thank you 13",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D13I.png",
ImgHoz = "LV-Thank You-D13S.svg",
SvgVer = "LV-Thank You-N13S.svg",
SvgHoz = "LV-Thank You-N13S.svg"
},
new Template
{
TemplateName = "Thank you 14",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D14I.png",
ImgHoz = "LV-Thank You-D14S.svg",
SvgVer = "LV-Thank You-N14S.svg",
SvgHoz = "LV-Thank You-N14S.svg"
},
new Template
{
TemplateName = "Thank you 15",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D15I.png",
ImgHoz = "LV-Thank You-D15S.svg",
SvgVer = "LV-Thank You-N15S.svg",
SvgHoz = "LV-Thank You-N15S.svg"
},
new Template
{
TemplateName = "Congratulation 1",
CategoryID =25,
Description = "",
Price = (float)5.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D16I.png",
ImgHoz = "LV-Thank You-D16S.svg",
SvgVer = "LV-Thank You-N16S.svg",
SvgHoz = "LV-Thank You-N16S.svg"
},
new Template
{
TemplateName = "Thank you 16",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D17I.png",
ImgHoz = "LV-Thank You-D17S.svg",
SvgVer = "LV-Thank You-N17S.svg",
SvgHoz = "LV-Thank You-N17S.svg"
},
new Template
{
TemplateName = "Thank you 17",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D18I.png",
ImgHoz = "LV-Thank You-D18S.svg",
SvgVer = "LV-Thank You-N18S.svg",
SvgHoz = "LV-Thank You-N18S.svg"
},
new Template
{
TemplateName = "Congratulation 2",
CategoryID =25,
Description = "",
Price = (float)5.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D19I.png",
ImgHoz = "LV-Thank You-D19S.svg",
SvgVer = "LV-Thank You-N19S.svg",
SvgHoz = "LV-Thank You-N19S.svg"
},
new Template
{
TemplateName = "Thank you 18",
CategoryID =25,
Description = "",
Price = (float)3.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Thank You-D20I.png",
ImgHoz = "LV-Thank You-D20S.svg",
SvgVer = "LV-Thank You-N20S.svg",
SvgHoz = "LV-Thank You-N20S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 1",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D1I.png",
ImgHoz = "LV-Anniversary-D1S.svg",
SvgVer = "LV-Anniversary-N1S.svg",
SvgHoz = "LV-Anniversary-N1S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 2",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D2I.png",
ImgHoz = "LV-Anniversary-D2S.svg",
SvgVer = "LV-Anniversary-N2S.svg",
SvgHoz = "LV-Anniversary-N2S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 3",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D3I.png",
ImgHoz = "LV-Anniversary-D3S.svg",
SvgVer = "LV-Anniversary-N3S.svg",
SvgHoz = "LV-Anniversary-N3S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 4",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D4I.png",
ImgHoz = "LV-Anniversary-D4S.svg",
SvgVer = "LV-Anniversary-N4S.svg",
SvgHoz = "LV-Anniversary-N4S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 5",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D5I.png",
ImgHoz = "LV-Anniversary-D5S.svg",
SvgVer = "LV-Anniversary-N5S.svg",
SvgHoz = "LV-Anniversary-N5S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 6",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D6I.png",
ImgHoz = "LV-Anniversary-D6S.svg",
SvgVer = "LV-Anniversary-N6S.svg",
SvgHoz = "LV-Anniversary-N6S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 7",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D7I.png",
ImgHoz = "LV-Anniversary-D7S.svg",
SvgVer = "LV-Anniversary-N7S.svg",
SvgHoz = "LV-Anniversary-N7S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 8",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D8I.png",
ImgHoz = "LV-Anniversary-D8S.svg",
SvgVer = "LV-Anniversary-N8S.svg",
SvgHoz = "LV-Anniversary-N8S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 9",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D9I.png",
ImgHoz = "LV-Anniversary-D9S.svg",
SvgVer = "LV-Anniversary-N9S.svg",
SvgHoz = "LV-Anniversary-N9S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 10",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D10I.png",
ImgHoz = "LV-Anniversary-D10S.svg",
SvgVer = "LV-Anniversary-N10S.svg",
SvgHoz = "LV-Anniversary-N10S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 11",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D11I.png",
ImgHoz = "LV-Anniversary-D11S.svg",
SvgVer = "LV-Anniversary-N11S.svg",
SvgHoz = "LV-Anniversary-N11S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 12",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D12I.png",
ImgHoz = "LV-Anniversary-D12S.svg",
SvgVer = "LV-Anniversary-N12S.svg",
SvgHoz = "LV-Anniversary-N12S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 13",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D13I.png",
ImgHoz = "LV-Anniversary-D13S.svg",
SvgVer = "LV-Anniversary-N13S.svg",
SvgHoz = "LV-Anniversary-N13S.svg"
},
new Template
{
TemplateName = "Happy Anniversary 14",
CategoryID =26,
Description = "",
Price = (float)5.2,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "LV-Anniversary-D14I.png",
ImgHoz = "LV-Anniversary-D14S.svg",
SvgVer = "LV-Anniversary-N14S.svg",
SvgHoz = "LV-Anniversary-N14S.svg"
},
new Template
{
TemplateName = "Turkey Day",
CategoryID =27,
Description = "Batangas",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD1.png",
ImgHoz = "Fes_TksGiving_SD1.svg",
SvgVer = "Fes_TksGiving_SN1.svg",
SvgHoz = "Fes_TksGiving_SN1.svg"
},
new Template
{
TemplateName = "Autumn Special Day",
CategoryID =27,
Description = "Open Sans",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD2.png",
ImgHoz = "Fes_TksGiving_SD2.svg",
SvgVer = "Fes_TksGiving_SN2.svg",
SvgHoz = "Fes_TksGiving_SN2.svg"
},
new Template
{
TemplateName = "Orange Food",
CategoryID =27,
Description = "Cooper BT",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD3.png",
ImgHoz = "Fes_TksGiving_SD3.svg",
SvgVer = "Fes_TksGiving_SN3.svg",
SvgHoz = "Fes_TksGiving_SN3.svg"
},
new Template
{
TemplateName = "Cake And Love",
CategoryID =27,
Description = "Cardo",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD4.png",
ImgHoz = "Fes_TksGiving_SD4.svg",
SvgVer = "Fes_TksGiving_SN4.svg",
SvgHoz = "Fes_TksGiving_SN4.svg"
},
new Template
{
TemplateName = "Sunset Festival",
CategoryID =27,
Description = "Cardo",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD5.png",
ImgHoz = "Fes_TksGiving_SD5.svg",
SvgVer = "Fes_TksGiving_SN5.svg",
SvgHoz = "Fes_TksGiving_SN5.svg"
},
new Template
{
TemplateName = "Special Turkey",
CategoryID =27,
Description = "Monserrat",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD6.png",
ImgHoz = "Fes_TksGiving_SD6.svg",
SvgVer = "Fes_TksGiving_SN6.svg",
SvgHoz = "Fes_TksGiving_SN6.svg"
},
new Template
{
TemplateName = "Big Dishes",
CategoryID =27,
Description = "Poppins",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD7.png",
ImgHoz = "Fes_TksGiving_SD7.svg",
SvgVer = "Fes_TksGiving_SN7.svg",
SvgHoz = "Fes_TksGiving_SN7.svg"
},
new Template
{
TemplateName = "Get Hot",
CategoryID =27,
Description = "Sailors",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD8.png",
ImgHoz = "Fes_TksGiving_SD8.svg",
SvgVer = "Fes_TksGiving_SN8.svg",
SvgHoz = "Fes_TksGiving_SN8.svg"
},
new Template
{
TemplateName = "Family Together",
CategoryID =27,
Description = "Fredoka",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD9.png",
ImgHoz = "Fes_TksGiving_SD9.svg",
SvgVer = "Fes_TksGiving_SN9.svg",
SvgHoz = "Fes_TksGiving_SN9.svg"
},
new Template
{
TemplateName = "Mushroom In The Party",
CategoryID =27,
Description = "Dynamo Condensed",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD10.png",
ImgHoz = "Fes_TksGiving_SD10.svg",
SvgVer = "Fes_TksGiving_SN10.svg",
SvgHoz = "Fes_TksGiving_SN10.svg"
},
new Template
{
TemplateName = "Pumpkin Is Autumn",
CategoryID =27,
Description = "Bebas Neue",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD11.png",
ImgHoz = "Fes_TksGiving_SD11.svg",
SvgVer = "Fes_TksGiving_SN11.svg",
SvgHoz = "Fes_TksGiving_SN11.svg"
},
new Template
{
TemplateName = "Dinner Spinner",
CategoryID =27,
Description = "Handy Casual",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD12.png",
ImgHoz = "Fes_TksGiving_SD12.svg",
SvgVer = "Fes_TksGiving_SN12.svg",
SvgHoz = "Fes_TksGiving_SN12.svg"
},
new Template
{
TemplateName = "Species Not Included",
CategoryID =27,
Description = "Monserrat",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD13.png",
ImgHoz = "Fes_TksGiving_SD13.svg",
SvgVer = "Fes_TksGiving_SN13.svg",
SvgHoz = "Fes_TksGiving_SN13.svg"
},
new Template
{
TemplateName = "Hanging Dancing",
CategoryID =27,
Description = "Compotes Citro",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD14.png",
ImgHoz = "Fes_TksGiving_SD14.svg",
SvgVer = "Fes_TksGiving_SN14.svg",
SvgHoz = "Fes_TksGiving_SN14.svg"
},
new Template
{
TemplateName = "Green To Be Seen",
CategoryID =27,
Description = "Josefin Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_TksGiving_PD15.png",
ImgHoz = "Fes_TksGiving_SD15.svg",
SvgVer = "Fes_TksGiving_SN15.svg",
SvgHoz = "Fes_TksGiving_SN15.svg"
},
new Template
{
TemplateName = "Sweet Christmas",
CategoryID =28,
Description = "Canva Sans",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD1.png",
ImgHoz = "Fes_Christmas_SD1.svg",
SvgVer = "Fes_Christmas_SN1.svg",
SvgHoz = "Fes_Christmas_SN1.svg"
},
new Template
{
TemplateName = "Winter Potluck",
CategoryID =28,
Description = "Agrandir",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD2.png",
ImgHoz = "Fes_Christmas_SD2.svg",
SvgVer = "Fes_Christmas_SN2.svg",
SvgHoz = "Fes_Christmas_SN2.svg"
},
new Template
{
TemplateName = "Christmas Tree",
CategoryID =28,
Description = "DM Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD3.png",
ImgHoz = "Fes_Christmas_SD3.svg",
SvgVer = "Fes_Christmas_SN3.svg",
SvgHoz = "Fes_Christmas_SN3.svg"
},
new Template
{
TemplateName = "Greendy Xmas",
CategoryID =28,
Description = "Garet",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD4.png",
ImgHoz = "Fes_Christmas_SD4.svg",
SvgVer = "Fes_Christmas_SN4.svg",
SvgHoz = "Fes_Christmas_SN4.svg"
},
new Template
{
TemplateName = "Candy Santa",
CategoryID =28,
Description = "Batangas",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD5.png",
ImgHoz = "Fes_Christmas_SD5.svg",
SvgVer = "Fes_Christmas_SN5.svg",
SvgHoz = "Fes_Christmas_SN5.svg"
},
new Template
{
TemplateName = "Hanging Present",
CategoryID =28,
Description = "Agrandir Wide",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD6.png",
ImgHoz = "Fes_Christmas_SD6.svg",
SvgVer = "Fes_Christmas_SN6.svg",
SvgHoz = "Fes_Christmas_SN6.svg"
},
new Template
{
TemplateName = "Lucky Christmas",
CategoryID =28,
Description = "DM Sans",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD7.png",
ImgHoz = "Fes_Christmas_SD7.svg",
SvgVer = "Fes_Christmas_SN7.svg",
SvgHoz = "Fes_Christmas_SN7.svg"
},
new Template
{
TemplateName = "White Christmas",
CategoryID =28,
Description = "ITC Benguiat",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD8.png",
ImgHoz = "Fes_Christmas_SD8.svg",
SvgVer = "Fes_Christmas_SN8.svg",
SvgHoz = "Fes_Christmas_SN8.svg"
},
new Template
{
TemplateName = "Santa Pass By",
CategoryID =28,
Description = "Sukar",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD9.png",
ImgHoz = "Fes_Christmas_SD9.svg",
SvgVer = "Fes_Christmas_SN9.svg",
SvgHoz = "Fes_Christmas_SN9.svg"
},
new Template
{
TemplateName = "Cutie Deer",
CategoryID =28,
Description = "Dreaming Outloud All Caps",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD10.png",
ImgHoz = "Fes_Christmas_SD10.svg",
SvgVer = "Fes_Christmas_SN10.svg",
SvgHoz = "Fes_Christmas_SN10.svg"
},
new Template
{
TemplateName = "Light Town",
CategoryID =28,
Description = "Roca Two",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD11.png",
ImgHoz = "Fes_Christmas_SD11.svg",
SvgVer = "Fes_Christmas_SN11.svg",
SvgHoz = "Fes_Christmas_SN11.svg"
},
new Template
{
TemplateName = "Red Respresent Present",
CategoryID =28,
Description = "Kollektif",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD12.png",
ImgHoz = "Fes_Christmas_SD12.svg",
SvgVer = "Fes_Christmas_SN12.svg",
SvgHoz = "Fes_Christmas_SN12.svg"
},
new Template
{
TemplateName = "Laurel Wreath",
CategoryID =28,
Description = "Kollektif",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD13.png",
ImgHoz = "Fes_Christmas_SD13.svg",
SvgVer = "Fes_Christmas_SN13.svg",
SvgHoz = "Fes_Christmas_SN13.svg"
},
new Template
{
TemplateName = "Under Christmas Tree",
CategoryID =28,
Description = "Batangas",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD14.png",
ImgHoz = "Fes_Christmas_SD14.svg",
SvgVer = "Fes_Christmas_SN14.svg",
SvgHoz = "Fes_Christmas_SN14.svg"
},
new Template
{
TemplateName = "Let's Sing Jingle Bell",
CategoryID =28,
Description = "Batangas",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Christmas_PD15.png",
ImgHoz = "Fes_Christmas_SD15.svg",
SvgVer = "Fes_Christmas_SN15.svg",
SvgHoz = "Fes_Christmas_SN15.svg"
},
new Template
{
TemplateName = "Buuny Day",
CategoryID =29,
Description = "Lumios Typewritter Old",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD1.png",
ImgHoz = "Fes_Easter_SD1.svg",
SvgVer = "Fes_Easter_SN1.svg",
SvgHoz = "Fes_Easter_SN1.svg"
},
new Template
{
TemplateName = "Green Easter",
CategoryID =29,
Description = "Lumios Typewritter Old",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD2.png",
ImgHoz = "Fes_Easter_SD2.svg",
SvgVer = "Fes_Easter_SN2.svg",
SvgHoz = "Fes_Easter_SN2.svg"
},
new Template
{
TemplateName = "Reborn Day",
CategoryID =29,
Description = "Lumios Typewritter Old",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD3.png",
ImgHoz = "Fes_Easter_SD3.svg",
SvgVer = "Fes_Easter_SN3.svg",
SvgHoz = "Fes_Easter_SN3.svg"
},
new Template
{
TemplateName = "Egg Hunt",
CategoryID =29,
Description = "Kollektif",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD4.png",
ImgHoz = "Fes_Easter_SD4.svg",
SvgVer = "Fes_Easter_SN4.svg",
SvgHoz = "Fes_Easter_SN4.svg"
},
new Template
{
TemplateName = "Rabit Hunt Egg",
CategoryID =29,
Description = "Bobby Jones Soft",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD5.png",
ImgHoz = "Fes_Easter_SD5.svg",
SvgVer = "Fes_Easter_SN5.svg",
SvgHoz = "Fes_Easter_SN5.svg"
},
new Template
{
TemplateName = "Flower Egg",
CategoryID =29,
Description = "DM Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD6.png",
ImgHoz = "Fes_Easter_SD6.svg",
SvgVer = "Fes_Easter_SN6.svg",
SvgHoz = "Fes_Easter_SN6.svg"
},
new Template
{
TemplateName = "Color The Egg",
CategoryID =29,
Description = "One Little Font",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD7.png",
ImgHoz = "Fes_Easter_SD7.svg",
SvgVer = "Fes_Easter_SN7.svg",
SvgHoz = "Fes_Easter_SN7.svg"
},
new Template
{
TemplateName = "Spring",
CategoryID =29,
Description = "Lumios Typewritter Old",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD8.png",
ImgHoz = "Fes_Easter_SD8.svg",
SvgVer = "Fes_Easter_SN8.svg",
SvgHoz = "Fes_Easter_SN8.svg"
},
new Template
{
TemplateName = "Chocolate Egg",
CategoryID =29,
Description = "One Little Font",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD9.png",
ImgHoz = "Fes_Easter_SD9.svg",
SvgVer = "Fes_Easter_SN9.svg",
SvgHoz = "Fes_Easter_SN9.svg"
},
new Template
{
TemplateName = "Different Layout",
CategoryID =29,
Description = "One Little Font",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Easter_PD10.png",
ImgHoz = "Fes_Easter_SD10.svg",
SvgVer = "Fes_Easter_SN10.svg",
SvgHoz = "Fes_Easter_SN10.svg"
},
new Template
{
TemplateName = "Enjoy The Moon",
CategoryID =30,
Description = "Berkshire Swash, Hero",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD1.png",
ImgHoz = "Fes_MidAut_SD1.svg",
SvgVer = "Fes_MidAut_SN1.svg",
SvgHoz = "Fes_MidAut_SN1.svg"
},
new Template
{
TemplateName = "Red Lattern",
CategoryID =30,
Description = "Berkshire Swash, Hero",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD2.png",
ImgHoz = "Fes_MidAut_SD2.svg",
SvgVer = "Fes_MidAut_SN2.svg",
SvgHoz = "Fes_MidAut_SN2.svg"
},
new Template
{
TemplateName = "Bunny Funny",
CategoryID =30,
Description = "Berkshire Swash, Hero",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD3.png",
ImgHoz = "Fes_MidAut_SD3.svg",
SvgVer = "Fes_MidAut_SN3.svg",
SvgHoz = "Fes_MidAut_SN3.svg"
},
new Template
{
TemplateName = "In The Temple",
CategoryID =30,
Description = "Glacial Indifference",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD4.png",
ImgHoz = "Fes_MidAut_SD4.svg",
SvgVer = "Fes_MidAut_SN4.svg",
SvgHoz = "Fes_MidAut_SN4.svg"
},
new Template
{
TemplateName = "Red Lattern",
CategoryID =30,
Description = "Tex Gyre Bonum",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD5.png",
ImgHoz = "Fes_MidAut_SD5.svg",
SvgVer = "Fes_MidAut_SN5.svg",
SvgHoz = "Fes_MidAut_SN5.svg"
},
new Template
{
TemplateName = "White Flower",
CategoryID =30,
Description = "Caveat Brush",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD6.png",
ImgHoz = "Fes_MidAut_SD6.svg",
SvgVer = "Fes_MidAut_SN6.svg",
SvgHoz = "Fes_MidAut_SN6.svg"
},
new Template
{
TemplateName = "Flower Latterns",
CategoryID =30,
Description = "Crave Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD7.png",
ImgHoz = "Fes_MidAut_SD7.svg",
SvgVer = "Fes_MidAut_SN7.svg",
SvgHoz = "Fes_MidAut_SN7.svg"
},
new Template
{
TemplateName = "Luxury Mid-Autumn",
CategoryID =30,
Description = "Berkshire Swash, Hero",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD8.png",
ImgHoz = "Fes_MidAut_SD8.svg",
SvgVer = "Fes_MidAut_SN8.svg",
SvgHoz = "Fes_MidAut_SN8.svg"
},
new Template
{
TemplateName = "Happiness",
CategoryID =30,
Description = "Berkshire Swash, Hero",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD9.png",
ImgHoz = "Fes_MidAut_SD9.svg",
SvgVer = "Fes_MidAut_SN9.svg",
SvgHoz = "Fes_MidAut_SN9.svg"
},
new Template
{
TemplateName = "Chinese Party",
CategoryID =30,
Description = "Berkshire Swash, Hero",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD10.png",
ImgHoz = "Fes_MidAut_SD10.svg",
SvgVer = "Fes_MidAut_SN10.svg",
SvgHoz = "Fes_MidAut_SN10.svg"
},
new Template
{
TemplateName = "Beauty Sky",
CategoryID =30,
Description = "Crave Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD11.png",
ImgHoz = "Fes_MidAut_SD11.svg",
SvgVer = "Fes_MidAut_SN11.svg",
SvgHoz = "Fes_MidAut_SN11.svg"
},
new Template
{
TemplateName = "Celebrate In Western",
CategoryID =30,
Description = "Amaranth",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD12.png",
ImgHoz = "Fes_MidAut_SD12.svg",
SvgVer = "Fes_MidAut_SN12.svg",
SvgHoz = "Fes_MidAut_SN12.svg"
},
new Template
{
TemplateName = "Pattern and Candle",
CategoryID =30,
Description = "Tex Gyre Bonum, Roca One",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD13.png",
ImgHoz = "Fes_MidAut_SD13.svg",
SvgVer = "Fes_MidAut_SN13.svg",
SvgHoz = "Fes_MidAut_SN13.svg"
},
new Template
{
TemplateName = "Color Pattern",
CategoryID =30,
Description = "Trocchi",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD14.png",
ImgHoz = "Fes_MidAut_SD14.svg",
SvgVer = "Fes_MidAut_SN14.svg",
SvgHoz = "Fes_MidAut_SN14.svg"
},
new Template
{
TemplateName = "Deep In Red",
CategoryID =30,
Description = "Tex Gyre Bonum, Now",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_MidAut_PD15.png",
ImgHoz = "Fes_MidAut_SD15.svg",
SvgVer = "Fes_MidAut_SN15.svg",
SvgHoz = "Fes_MidAut_SN15.svg"
},
new Template
{
TemplateName = "Be The Pumpkin",
CategoryID =32,
Description = "Amaranth",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD1.png",
ImgHoz = "Fes_Halloween_SD1.svg",
SvgVer = "Fes_Halloween_SN1.svg",
SvgHoz = "Fes_Halloween_SN1.svg"
},
new Template
{
TemplateName = "Orange Autumn",
CategoryID =32,
Description = "Garet",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD2.png",
ImgHoz = "Fes_Halloween_SD2.svg",
SvgVer = "Fes_Halloween_SN2.svg",
SvgHoz = "Fes_Halloween_SN2.svg"
},
new Template
{
TemplateName = "Hunting Haunting",
CategoryID =32,
Description = "Chapbook",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD3.png",
ImgHoz = "Fes_Halloween_SD3.svg",
SvgVer = "Fes_Halloween_SN3.svg",
SvgHoz = "Fes_Halloween_SN3.svg"
},
new Template
{
TemplateName = "Black Cat",
CategoryID =32,
Description = "Jeepers",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD4.png",
ImgHoz = "Fes_Halloween_SD4.svg",
SvgVer = "Fes_Halloween_SN4.svg",
SvgHoz = "Fes_Halloween_SN4.svg"
},
new Template
{
TemplateName = "Ghosty Goodies",
CategoryID =32,
Description = "Now",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD5.png",
ImgHoz = "Fes_Halloween_SD5.svg",
SvgVer = "Fes_Halloween_SN5.svg",
SvgHoz = "Fes_Halloween_SN5.svg"
},
new Template
{
TemplateName = "Haunted Graveyard",
CategoryID =32,
Description = "Anantason Expanded",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD6.png",
ImgHoz = "Fes_Halloween_SD6.svg",
SvgVer = "Fes_Halloween_SN6.svg",
SvgHoz = "Fes_Halloween_SN6.svg"
},
new Template
{
TemplateName = "Sweet Posion",
CategoryID =32,
Description = "Glacial Indifference",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD7.png",
ImgHoz = "Fes_Halloween_SD7.svg",
SvgVer = "Fes_Halloween_SN7.svg",
SvgHoz = "Fes_Halloween_SN7.svg"
},
new Template
{
TemplateName = "Evil Pumpkin",
CategoryID =32,
Description = "Montserrat",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD8.png",
ImgHoz = "Fes_Halloween_SD8.svg",
SvgVer = "Fes_Halloween_SN8.svg",
SvgHoz = "Fes_Halloween_SN8.svg"
},
new Template
{
TemplateName = "Peka Boo",
CategoryID =32,
Description = "Special Elite",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD9.png",
ImgHoz = "Fes_Halloween_SD9.svg",
SvgVer = "Fes_Halloween_SN9.svg",
SvgHoz = "Fes_Halloween_SN9.svg"
},
new Template
{
TemplateName = "Old School News",
CategoryID =32,
Description = "Rye",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD10.png",
ImgHoz = "Fes_Halloween_SD10.svg",
SvgVer = "Fes_Halloween_SN10.svg",
SvgHoz = "Fes_Halloween_SN10.svg"
},
new Template
{
TemplateName = "Trap By Spiderweb",
CategoryID =32,
Description = "Della Respira",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD11.png",
ImgHoz = "Fes_Halloween_SD11.svg",
SvgVer = "Fes_Halloween_SN11.svg",
SvgHoz = "Fes_Halloween_SN11.svg"
},
new Template
{
TemplateName = "Bat Worlds",
CategoryID =32,
Description = "Sniglet",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD12.png",
ImgHoz = "Fes_Halloween_SD12.svg",
SvgVer = "Fes_Halloween_SN12.svg",
SvgHoz = "Fes_Halloween_SN12.svg"
},
new Template
{
TemplateName = "Purple Cloud",
CategoryID =32,
Description = "Tallow Sans Pen",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD13.png",
ImgHoz = "Fes_Halloween_SD13.svg",
SvgVer = "Fes_Halloween_SN13.svg",
SvgHoz = "Fes_Halloween_SN13.svg"
},
new Template
{
TemplateName = "Be On The Newspaper",
CategoryID =32,
Description = "Elders",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD14.png",
ImgHoz = "Fes_Halloween_SD14.svg",
SvgVer = "Fes_Halloween_SN14.svg",
SvgHoz = "Fes_Halloween_SN14.svg"
},
new Template
{
TemplateName = "See The Future",
CategoryID =32,
Description = "Maragsa",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Halloween_PD15.png",
ImgHoz = "Fes_Halloween_SD15.svg",
SvgVer = "Fes_Halloween_SN15.svg",
SvgHoz = "Fes_Halloween_SN15.svg"
},
new Template
{
TemplateName = "Till The Night",
CategoryID =33,
Description = "Coldiac",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD1.png",
ImgHoz = "Fes_Music_SD1.svg",
SvgVer = "Fes_Music_SN1.svg",
SvgHoz = "Fes_Music_SN1.svg"
},
new Template
{
TemplateName = "DJ Of The Day",
CategoryID =33,
Description = "Agrandir",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD2.png",
ImgHoz = "Fes_Music_SD2.svg",
SvgVer = "Fes_Music_SN2.svg",
SvgHoz = "Fes_Music_SN2.svg"
},
new Template
{
TemplateName = "Purple Night",
CategoryID =33,
Description = "Be Vietnam",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD3.png",
ImgHoz = "Fes_Music_SD3.svg",
SvgVer = "Fes_Music_SN3.svg",
SvgHoz = "Fes_Music_SN3.svg"
},
new Template
{
TemplateName = "Play Your Day",
CategoryID =33,
Description = "Ubuntu",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD4.png",
ImgHoz = "Fes_Music_SD4.svg",
SvgVer = "Fes_Music_SN4.svg",
SvgHoz = "Fes_Music_SN4.svg"
},
new Template
{
TemplateName = "Star Night",
CategoryID =33,
Description = "Arimo",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD5.png",
ImgHoz = "Fes_Music_SD5.svg",
SvgVer = "Fes_Music_SN5.svg",
SvgHoz = "Fes_Music_SN5.svg"
},
new Template
{
TemplateName = "Glow In The Dark",
CategoryID =33,
Description = "Raleway",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD6.png",
ImgHoz = "Fes_Music_SD6.svg",
SvgVer = "Fes_Music_SN6.svg",
SvgHoz = "Fes_Music_SN6.svg"
},
new Template
{
TemplateName = "Lost In The Crowd",
CategoryID =33,
Description = "Josefin Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD7.png",
ImgHoz = "Fes_Music_SD7.svg",
SvgVer = "Fes_Music_SN7.svg",
SvgHoz = "Fes_Music_SN7.svg"
},
new Template
{
TemplateName = "Rock Together",
CategoryID =33,
Description = "Aileron",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD8.png",
ImgHoz = "Fes_Music_SD8.svg",
SvgVer = "Fes_Music_SN8.svg",
SvgHoz = "Fes_Music_SN8.svg"
},
new Template
{
TemplateName = "Sparkling Sparkle",
CategoryID =33,
Description = "DM Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD9.png",
ImgHoz = "Fes_Music_SD9.svg",
SvgVer = "Fes_Music_SN9.svg",
SvgHoz = "Fes_Music_SN9.svg"
},
new Template
{
TemplateName = "Leave The World",
CategoryID =33,
Description = "Bebas Neue",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD10.png",
ImgHoz = "Fes_Music_SD10.svg",
SvgVer = "Fes_Music_SN10.svg",
SvgHoz = "Fes_Music_SN10.svg"
},
new Template
{
TemplateName = "Shine Like Daimond",
CategoryID =33,
Description = "Raleway",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD11.png",
ImgHoz = "Fes_Music_SD11.svg",
SvgVer = "Fes_Music_SN11.svg",
SvgHoz = "Fes_Music_SN11.svg"
},
new Template
{
TemplateName = "Lighting String",
CategoryID =33,
Description = "Sports World",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD12.png",
ImgHoz = "Fes_Music_SD12.svg",
SvgVer = "Fes_Music_SN12.svg",
SvgHoz = "Fes_Music_SN12.svg"
},
new Template
{
TemplateName = "Glooby Night",
CategoryID =33,
Description = "Etna Sans Serif",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD13.png",
ImgHoz = "Fes_Music_SD13.svg",
SvgVer = "Fes_Music_SN13.svg",
SvgHoz = "Fes_Music_SN13.svg"
},
new Template
{
TemplateName = "Be The Star",
CategoryID =33,
Description = "Nourd",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD14.png",
ImgHoz = "Fes_Music_SD14.svg",
SvgVer = "Fes_Music_SN14.svg",
SvgHoz = "Fes_Music_SN14.svg"
},
new Template
{
TemplateName = "Old Gramophone",
CategoryID =33,
Description = "Glacial Indifference",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Music_PD15.png",
ImgHoz = "Fes_Music_SD15.svg",
SvgVer = "Fes_Music_SN15.svg",
SvgHoz = "Fes_Music_SN15.svg"
},
new Template
{
TemplateName = "Boys Dance",
CategoryID =34,
Description = "Aileron",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Dance_PD1.png",
ImgHoz = "Fes_Dance_SD1.svg",
SvgVer = "Fes_Dance_SN1.svg",
SvgHoz = "Fes_Dance_SN1.svg"
},
new Template
{
TemplateName = "Street Dance",
CategoryID =34,
Description = "Monserrat",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Dance_PD2.png",
ImgHoz = "Fes_Dance_SD2.svg",
SvgVer = "Fes_Dance_SN2.svg",
SvgHoz = "Fes_Dance_SN2.svg"
},
new Template
{
TemplateName = "Be Girl Dancer",
CategoryID =34,
Description = "Garet",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Dance_PD3.png",
ImgHoz = "Fes_Dance_SD3.svg",
SvgVer = "Fes_Dance_SN3.svg",
SvgHoz = "Fes_Dance_SN3.svg"
},
new Template
{
TemplateName = "Dance Together",
CategoryID =34,
Description = "Aleo",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Dance_PD4.png",
ImgHoz = "Fes_Dance_SD4.svg",
SvgVer = "Fes_Dance_SN4.svg",
SvgHoz = "Fes_Dance_SN4.svg"
},
new Template
{
TemplateName = "Sparrking Tonight",
CategoryID =34,
Description = "Monserrat",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Dance_PD5.png",
ImgHoz = "Fes_Dance_SD5.svg",
SvgVer = "Fes_Dance_SN5.svg",
SvgHoz = "Fes_Dance_SN5.svg"
},
new Template
{
TemplateName = "Burgie Flavor",
CategoryID =35,
Description = "Lato",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD1.png",
ImgHoz = "Fes_Food_SD1.svg",
SvgVer = "Fes_Food_SN1.svg",
SvgHoz = "Fes_Food_SN1.svg"
},
new Template
{
TemplateName = "Fry The Chicken",
CategoryID =35,
Description = "Martel",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD2.png",
ImgHoz = "Fes_Food_SD2.svg",
SvgVer = "Fes_Food_SN2.svg",
SvgHoz = "Fes_Food_SN2.svg"
},
new Template
{
TemplateName = "Satay Day",
CategoryID =35,
Description = "Pushkin High",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD3.png",
ImgHoz = "Fes_Food_SD3.svg",
SvgVer = "Fes_Food_SN3.svg",
SvgHoz = "Fes_Food_SN3.svg"
},
new Template
{
TemplateName = "Be Green ",
CategoryID =35,
Description = "HK Grostek Pro",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD4.png",
ImgHoz = "Fes_Food_SD4.svg",
SvgVer = "Fes_Food_SN4.svg",
SvgHoz = "Fes_Food_SN4.svg"
},
new Template
{
TemplateName = "Burning Red",
CategoryID =35,
Description = "Lora",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD5.png",
ImgHoz = "Fes_Food_SD5.svg",
SvgVer = "Fes_Food_SN5.svg",
SvgHoz = "Fes_Food_SN5.svg"
},
new Template
{
TemplateName = "Real Pasta",
CategoryID =35,
Description = "Poppins",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD6.png",
ImgHoz = "Fes_Food_SD6.svg",
SvgVer = "Fes_Food_SN6.svg",
SvgHoz = "Fes_Food_SN6.svg"
},
new Template
{
TemplateName = "Best Pizza Cook",
CategoryID =35,
Description = "Porcelain",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD7.png",
ImgHoz = "Fes_Food_SD7.svg",
SvgVer = "Fes_Food_SN7.svg",
SvgHoz = "Fes_Food_SN7.svg"
},
new Template
{
TemplateName = "Green But Not Green",
CategoryID =35,
Description = "Genty Sans",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD8.png",
ImgHoz = "Fes_Food_SD8.svg",
SvgVer = "Fes_Food_SN8.svg",
SvgHoz = "Fes_Food_SN8.svg"
},
new Template
{
TemplateName = "Brunch Sunday",
CategoryID =35,
Description = "Agrandir Wide",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD9.png",
ImgHoz = "Fes_Food_SD9.svg",
SvgVer = "Fes_Food_SN9.svg",
SvgHoz = "Fes_Food_SN9.svg"
},
new Template
{
TemplateName = "Be In Japan",
CategoryID =35,
Description = "Poppins",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD10.png",
ImgHoz = "Fes_Food_SD10.svg",
SvgVer = "Fes_Food_SN10.svg",
SvgHoz = "Fes_Food_SN10.svg"
},
new Template
{
TemplateName = "Your Own Recipe",
CategoryID =35,
Description = "Arimo",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD11.png",
ImgHoz = "Fes_Food_SD11.svg",
SvgVer = "Fes_Food_SN11.svg",
SvgHoz = "Fes_Food_SN11.svg"
},
new Template
{
TemplateName = "Read The Bread",
CategoryID =35,
Description = "Open Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD12.png",
ImgHoz = "Fes_Food_SD12.svg",
SvgVer = "Fes_Food_SN12.svg",
SvgHoz = "Fes_Food_SN12.svg"
},
new Template
{
TemplateName = "Cool In Summer",
CategoryID =35,
Description = "Chewy",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD13.png",
ImgHoz = "Fes_Food_SD13.svg",
SvgVer = "Fes_Food_SN13.svg",
SvgHoz = "Fes_Food_SN13.svg"
},
new Template
{
TemplateName = "Travel To China",
CategoryID =35,
Description = "Bantayog",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD14.png",
ImgHoz = "Fes_Food_SD14.svg",
SvgVer = "Fes_Food_SN14.svg",
SvgHoz = "Fes_Food_SN14.svg"
},
new Template
{
TemplateName = "Meat And Cheese",
CategoryID =35,
Description = "Heading Now 61-68",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Food_PD15.png",
ImgHoz = "Fes_Food_SD15.svg",
SvgVer = "Fes_Food_SN15.svg",
SvgHoz = "Fes_Food_SN15.svg"
},
new Template
{
TemplateName = "Even Beauty When You Can't See",
CategoryID =36,
Description = "Monserrat",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD1.png",
ImgHoz = "Fes_Flower_SD1.svg",
SvgVer = "Fes_Flower_SN1.svg",
SvgHoz = "Fes_Flower_SN1.svg"
},
new Template
{
TemplateName = "Enjoy Hydrangea",
CategoryID =36,
Description = "Evolventa",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD2.png",
ImgHoz = "Fes_Flower_SD2.svg",
SvgVer = "Fes_Flower_SN2.svg",
SvgHoz = "Fes_Flower_SN2.svg"
},
new Template
{
TemplateName = "New Thing With Nature",
CategoryID =36,
Description = "Antic",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD3.png",
ImgHoz = "Fes_Flower_SD3.svg",
SvgVer = "Fes_Flower_SN3.svg",
SvgHoz = "Fes_Flower_SN3.svg"
},
new Template
{
TemplateName = "Simple Beauty",
CategoryID =36,
Description = "Antic",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD4.png",
ImgHoz = "Fes_Flower_SD4.svg",
SvgVer = "Fes_Flower_SN4.svg",
SvgHoz = "Fes_Flower_SN4.svg"
},
new Template
{
TemplateName = "Blooming Party",
CategoryID =36,
Description = "Quattrocento",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD5.png",
ImgHoz = "Fes_Flower_SD5.svg",
SvgVer = "Fes_Flower_SN5.svg",
SvgHoz = "Fes_Flower_SN5.svg"
},
new Template
{
TemplateName = "Flower Garden",
CategoryID =36,
Description = "Quattrocento",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD6.png",
ImgHoz = "Fes_Flower_SD6.svg",
SvgVer = "Fes_Flower_SN6.svg",
SvgHoz = "Fes_Flower_SN6.svg"
},
new Template
{
TemplateName = "Even No Color",
CategoryID =36,
Description = "Colben",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD7.png",
ImgHoz = "Fes_Flower_SD7.svg",
SvgVer = "Fes_Flower_SN7.svg",
SvgHoz = "Fes_Flower_SN7.svg"
},
new Template
{
TemplateName = "Beauty Pink",
CategoryID =36,
Description = "Glacial Indifference",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD8.png",
ImgHoz = "Fes_Flower_SD8.svg",
SvgVer = "Fes_Flower_SN8.svg",
SvgHoz = "Fes_Flower_SN8.svg"
},
new Template
{
TemplateName = "Creative Gift",
CategoryID =36,
Description = "Lato",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD9.png",
ImgHoz = "Fes_Flower_SD9.svg",
SvgVer = "Fes_Flower_SN9.svg",
SvgHoz = "Fes_Flower_SN9.svg"
},
new Template
{
TemplateName = "Tulip Day",
CategoryID =36,
Description = "Agrandir",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Flower_PD10.png",
ImgHoz = "Fes_Flower_SD10.svg",
SvgVer = "Fes_Flower_SN10.svg",
SvgHoz = "Fes_Flower_SN10.svg"
},
new Template
{
TemplateName = "Single But Happy",
CategoryID =37,
Description = "More Sugar",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Single_PD1.png",
ImgHoz = "Fes_Single_SD1.svg",
SvgVer = "Fes_Single_SN1.svg",
SvgHoz = "Fes_Single_SN1.svg"
},
new Template
{
TemplateName = "I Believe In Me",
CategoryID =37,
Description = "TAN Nimbus",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Single_PD2.png",
ImgHoz = "Fes_Single_SD2.svg",
SvgVer = "Fes_Single_SN2.svg",
SvgHoz = "Fes_Single_SN2.svg"
},
new Template
{
TemplateName = "Self Hug",
CategoryID =37,
Description = "Monserrat",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Single_PD3.png",
ImgHoz = "Fes_Single_SD3.svg",
SvgVer = "Fes_Single_SN3.svg",
SvgHoz = "Fes_Single_SN3.svg"
},
new Template
{
TemplateName = "Alone Not Lonely",
CategoryID =37,
Description = "Sensei",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Single_PD4.png",
ImgHoz = "Fes_Single_SD4.svg",
SvgVer = "Fes_Single_SN4.svg",
SvgHoz = "Fes_Single_SN4.svg"
},
new Template
{
TemplateName = "Healthy In And Out",
CategoryID =37,
Description = "Gaegu",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "Fes_Single_PD5.png",
ImgHoz = "Fes_Single_SD5.svg",
SvgVer = "Fes_Single_SN5.svg",
SvgHoz = "Fes_Single_SN5.svg"
},
new Template
{
TemplateName = "We Are All Pretty",
CategoryID =38,
Description = "Glacial Indifference",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD1.png",
ImgHoz = "OT_Women_SD1.svg",
SvgVer = "OT_Women_SN1.svg",
SvgHoz = "OT_Women_SN1.svg"
},
new Template
{
TemplateName = "No Matter What You Do",
CategoryID =38,
Description = "Monserrat",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD2.png",
ImgHoz = "OT_Women_SD2.svg",
SvgVer = "OT_Women_SN2.svg",
SvgHoz = "OT_Women_SN2.svg"
},
new Template
{
TemplateName = "All Deserve Love",
CategoryID =38,
Description = "Gayathri",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD3.png",
ImgHoz = "OT_Women_SD3.svg",
SvgVer = "OT_Women_SN3.svg",
SvgHoz = "OT_Women_SN3.svg"
},
new Template
{
TemplateName = "We Support Each Other",
CategoryID =38,
Description = "Cy Grotesk Key",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD4.png",
ImgHoz = "OT_Women_SD4.svg",
SvgVer = "OT_Women_SN4.svg",
SvgHoz = "OT_Women_SN4.svg"
},
new Template
{
TemplateName = "Free To Be Different",
CategoryID =38,
Description = "Marykate",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD5.png",
ImgHoz = "OT_Women_SD5.svg",
SvgVer = "OT_Women_SN5.svg",
SvgHoz = "OT_Women_SN5.svg"
},
new Template
{
TemplateName = "We Enjoy The Simple",
CategoryID =38,
Description = "Kollektif",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD6.png",
ImgHoz = "OT_Women_SD6.svg",
SvgVer = "OT_Women_SN6.svg",
SvgHoz = "OT_Women_SN6.svg"
},
new Template
{
TemplateName = "Incredible Support",
CategoryID =38,
Description = "Sanchez",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD7.png",
ImgHoz = "OT_Women_SD7.svg",
SvgVer = "OT_Women_SN7.svg",
SvgHoz = "OT_Women_SN7.svg"
},
new Template
{
TemplateName = "Empowered Women",
CategoryID =38,
Description = "Agrandir Tight",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD8.png",
ImgHoz = "OT_Women_SD8.svg",
SvgVer = "OT_Women_SN8.svg",
SvgHoz = "OT_Women_SN8.svg"
},
new Template
{
TemplateName = "Different But Still Match",
CategoryID =38,
Description = "Louisville I",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD9.png",
ImgHoz = "OT_Women_SD9.svg",
SvgVer = "OT_Women_SN9.svg",
SvgHoz = "OT_Women_SN9.svg"
},
new Template
{
TemplateName = "Sister Alliance",
CategoryID =38,
Description = "Louisville I",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Women_PD10.png",
ImgHoz = "OT_Women_SD10.svg",
SvgVer = "OT_Women_SN10.svg",
SvgHoz = "OT_Women_SN10.svg"
},
new Template
{
TemplateName = "Strong And Pretty",
CategoryID =39,
Description = "Droid Serif",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD1.png",
ImgHoz = "OT_WomenVN_SD1.svg",
SvgVer = "OT_WomenVN_SN1.svg",
SvgHoz = "OT_WomenVN_SN1.svg"
},
new Template
{
TemplateName = "Women Still Strong",
CategoryID =39,
Description = "Quicksand",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD2.png",
ImgHoz = "OT_WomenVN_SD2.svg",
SvgVer = "OT_WomenVN_SN2.svg",
SvgHoz = "OT_WomenVN_SN2.svg"
},
new Template
{
TemplateName = "Lightly Beauty",
CategoryID =39,
Description = "Quicksand",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD3.png",
ImgHoz = "OT_WomenVN_SD3.svg",
SvgVer = "OT_WomenVN_SN3.svg",
SvgHoz = "OT_WomenVN_SN3.svg"
},
new Template
{
TemplateName = "All About Beauty",
CategoryID =39,
Description = "Alice",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD4.png",
ImgHoz = "OT_WomenVN_SD4.svg",
SvgVer = "OT_WomenVN_SN4.svg",
SvgHoz = "OT_WomenVN_SN4.svg"
},
new Template
{
TemplateName = "All About Beauty",
CategoryID =39,
Description = "Art Nuvo",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD5.png",
ImgHoz = "OT_WomenVN_SD5.svg",
SvgVer = "OT_WomenVN_SN5.svg",
SvgHoz = "OT_WomenVN_SN5.svg"
},
new Template
{
TemplateName = "Simple But Attractive",
CategoryID =39,
Description = "Quicksand",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD6.png",
ImgHoz = "OT_WomenVN_SD6.svg",
SvgVer = "OT_WomenVN_SN6.svg",
SvgHoz = "OT_WomenVN_SN6.svg"
},
new Template
{
TemplateName = "White Live",
CategoryID =39,
Description = "Quicksand",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD7.png",
ImgHoz = "OT_WomenVN_SD7.svg",
SvgVer = "OT_WomenVN_SN7.svg",
SvgHoz = "OT_WomenVN_SN7.svg"
},
new Template
{
TemplateName = "One For Each Of Us",
CategoryID =39,
Description = "Quicksand",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD8.png",
ImgHoz = "OT_WomenVN_SD8.svg",
SvgVer = "OT_WomenVN_SN8.svg",
SvgHoz = "OT_WomenVN_SN8.svg"
},
new Template
{
TemplateName = "Roses For Us",
CategoryID =39,
Description = "Quicksand",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD9.png",
ImgHoz = "OT_WomenVN_SD9.svg",
SvgVer = "OT_WomenVN_SN9.svg",
SvgHoz = "OT_WomenVN_SN9.svg"
},
new Template
{
TemplateName = "Different Shape Of Beauty",
CategoryID =39,
Description = "Quicksand",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_WomenVN_PD10.png",
ImgHoz = "OT_WomenVN_SD10.svg",
SvgVer = "OT_WomenVN_SN10.svg",
SvgHoz = "OT_WomenVN_SN10.svg"
},
new Template
{
TemplateName = "Our Second Mom",
CategoryID =40,
Description = "Glacial Indifference",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD1.png",
ImgHoz = "OT_Teacher_SD1.svg",
SvgVer = "OT_Teacher_SN1.svg",
SvgHoz = "OT_Teacher_SN1.svg"
},
new Template
{
TemplateName = "Respect All",
CategoryID =40,
Description = "Marykate",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD2.png",
ImgHoz = "OT_Teacher_SD2.svg",
SvgVer = "OT_Teacher_SN2.svg",
SvgHoz = "OT_Teacher_SN2.svg"
},
new Template
{
TemplateName = "Thank You For Simple Thing",
CategoryID =40,
Description = "Bellaboo",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD3.png",
ImgHoz = "OT_Teacher_SD3.svg",
SvgVer = "OT_Teacher_SN3.svg",
SvgHoz = "OT_Teacher_SN3.svg"
},
new Template
{
TemplateName = "Endless Passion",
CategoryID =40,
Description = "Futura",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD4.png",
ImgHoz = "OT_Teacher_SD4.svg",
SvgVer = "OT_Teacher_SN4.svg",
SvgHoz = "OT_Teacher_SN4.svg"
},
new Template
{
TemplateName = "We All Thank You",
CategoryID =40,
Description = "Playfair Display",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD5.png",
ImgHoz = "OT_Teacher_SD5.svg",
SvgVer = "OT_Teacher_SN5.svg",
SvgHoz = "OT_Teacher_SN5.svg"
},
new Template
{
TemplateName = "Our Student Time",
CategoryID =40,
Description = "Glacial Indifference",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD6.png",
ImgHoz = "OT_Teacher_SD6.svg",
SvgVer = "OT_Teacher_SN6.svg",
SvgHoz = "OT_Teacher_SN6.svg"
},
new Template
{
TemplateName = "Bloom Thank To You",
CategoryID =40,
Description = "Playwrite US Mordern",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD7.png",
ImgHoz = "OT_Teacher_SD7.svg",
SvgVer = "OT_Teacher_SN7.svg",
SvgHoz = "OT_Teacher_SN7.svg"
},
new Template
{
TemplateName = "All Beautiful Flowers To You",
CategoryID =40,
Description = "Glacial Indifference",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD8.png",
ImgHoz = "OT_Teacher_SD8.svg",
SvgVer = "OT_Teacher_SN8.svg",
SvgHoz = "OT_Teacher_SN8.svg"
},
new Template
{
TemplateName = "Purple Thank",
CategoryID =40,
Description = "Glacial Indifference",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD9.png",
ImgHoz = "OT_Teacher_SD9.svg",
SvgVer = "OT_Teacher_SN9.svg",
SvgHoz = "OT_Teacher_SN9.svg"
},
new Template
{
TemplateName = "Simple Respect",
CategoryID =40,
Description = "Dancing Script",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Teacher_PD10.png",
ImgHoz = "OT_Teacher_SD10.svg",
SvgVer = "OT_Teacher_SN10.svg",
SvgHoz = "OT_Teacher_SN10.svg"
},
new Template
{
TemplateName = "Around The World",
CategoryID =41,
Description = "Glacial Indifference",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD1.png",
ImgHoz = "OT_Children_SD1.svg",
SvgVer = "OT_Children_SN1.svg",
SvgHoz = "OT_Children_SN1.svg"
},
new Template
{
TemplateName = "Kid's Dream",
CategoryID =41,
Description = "Poppins Bold",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD2.png",
ImgHoz = "OT_Children_SD2.svg",
SvgVer = "OT_Children_SN2.svg",
SvgHoz = "OT_Children_SN2.svg"
},
new Template
{
TemplateName = "They are our future",
CategoryID =41,
Description = "Bellaboo",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD3.png",
ImgHoz = "OT_Children_SD3.svg",
SvgVer = "OT_Children_SN3.svg",
SvgHoz = "OT_Children_SN3.svg"
},
new Template
{
TemplateName = "Playground Play Now",
CategoryID =41,
Description = "Glacial Indifference",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD4.png",
ImgHoz = "OT_Children_SD4.svg",
SvgVer = "OT_Children_SN4.svg",
SvgHoz = "OT_Children_SN4.svg"
},
new Template
{
TemplateName = "Be Happy When Be A Kid",
CategoryID =41,
Description = "Bellaboo",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD5.png",
ImgHoz = "OT_Children_SD5.svg",
SvgVer = "OT_Children_SN5.svg",
SvgHoz = "OT_Children_SN5.svg"
},
new Template
{
TemplateName = "Us Together",
CategoryID =41,
Description = "Poppins Bold",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD6.png",
ImgHoz = "OT_Children_SD6.svg",
SvgVer = "OT_Children_SN6.svg",
SvgHoz = "OT_Children_SN6.svg"
},
new Template
{
TemplateName = "It's My Future",
CategoryID =41,
Description = "Bellaboo",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD7.png",
ImgHoz = "OT_Children_SD7.svg",
SvgVer = "OT_Children_SN7.svg",
SvgHoz = "OT_Children_SN7.svg"
},
new Template
{
TemplateName = "We're All Friends",
CategoryID =41,
Description = "Now",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD8.png",
ImgHoz = "OT_Children_SD8.svg",
SvgVer = "OT_Children_SN8.svg",
SvgHoz = "OT_Children_SN8.svg"
},
new Template
{
TemplateName = "Our Childhood",
CategoryID =41,
Description = "Gaegu",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD9.png",
ImgHoz = "OT_Children_SD9.svg",
SvgVer = "OT_Children_SN9.svg",
SvgHoz = "OT_Children_SN9.svg"
},
new Template
{
TemplateName = "Being Us",
CategoryID =41,
Description = "Open Sans",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Children_PD10.png",
ImgHoz = "OT_Children_SD10.svg",
SvgVer = "OT_Children_SN10.svg",
SvgHoz = "OT_Children_SN10.svg"
},
new Template
{
TemplateName = "My Degree",
CategoryID =42,
Description = "Roboto Mono",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD1.png",
ImgHoz = "OT_Grad_SD1.svg",
SvgVer = "OT_Grad_SN1.svg",
SvgHoz = "OT_Grad_SN1.svg"
},
new Template
{
TemplateName = "Graduation Postcard",
CategoryID =42,
Description = "Open Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD2.png",
ImgHoz = "OT_Grad_SD2.svg",
SvgVer = "OT_Grad_SN2.svg",
SvgHoz = "OT_Grad_SN2.svg"
},
new Template
{
TemplateName = "Last Time Highschool",
CategoryID =42,
Description = "Adolescence",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD3.png",
ImgHoz = "OT_Grad_SD3.svg",
SvgVer = "OT_Grad_SN3.svg",
SvgHoz = "OT_Grad_SN3.svg"
},
new Template
{
TemplateName = "Like Celebrity",
CategoryID =42,
Description = "Monserrat Classic",
Price = (float)1,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD4.png",
ImgHoz = "OT_Grad_SD4.svg",
SvgVer = "OT_Grad_SN4.svg",
SvgHoz = "OT_Grad_SN4.svg"
},
new Template
{
TemplateName = "Sparkling Future",
CategoryID =42,
Description = "Forum",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD5.png",
ImgHoz = "OT_Grad_SD5.svg",
SvgVer = "OT_Grad_SN5.svg",
SvgHoz = "OT_Grad_SN5.svg"
},
new Template
{
TemplateName = "Fabulous Day",
CategoryID =42,
Description = "Maharlika",
Price = (float)0.75,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD6.png",
ImgHoz = "OT_Grad_SD6.svg",
SvgVer = "OT_Grad_SN6.svg",
SvgHoz = "OT_Grad_SN6.svg"
},
new Template
{
TemplateName = "Simple End For Simple Start",
CategoryID =42,
Description = "Radley",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD7.png",
ImgHoz = "OT_Grad_SD7.svg",
SvgVer = "OT_Grad_SN7.svg",
SvgHoz = "OT_Grad_SN7.svg"
},
new Template
{
TemplateName = "Become My Memory",
CategoryID =42,
Description = "Dejavu Serif",
Price = (float)0.5,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD8.png",
ImgHoz = "OT_Grad_SD8.svg",
SvgVer = "OT_Grad_SN8.svg",
SvgHoz = "OT_Grad_SN8.svg"
},
new Template
{
TemplateName = "Fly High",
CategoryID =42,
Description = "Dejavu Serif",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD9.png",
ImgHoz = "OT_Grad_SD9.svg",
SvgVer = "OT_Grad_SN9.svg",
SvgHoz = "OT_Grad_SN9.svg"
},
new Template
{
TemplateName = "Rose Road",
CategoryID =42,
Description = "Poppins",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Grad_PD10.png",
ImgHoz = "OT_Grad_SD10.svg",
SvgVer = "OT_Grad_SN10.svg",
SvgHoz = "OT_Grad_SN10.svg"
},
new Template
{
TemplateName = "The End And New Begin",
CategoryID =43,
Description = "Open Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD1.png",
ImgHoz = "OT_Party_SD1.svg",
SvgVer = "OT_Party_SN1.svg",
SvgHoz = "OT_Party_SN1.svg"
},
new Template
{
TemplateName = "Memory Where We Work",
CategoryID =43,
Description = "Open Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD2.png",
ImgHoz = "OT_Party_SD2.svg",
SvgVer = "OT_Party_SN2.svg",
SvgHoz = "OT_Party_SN2.svg"
},
new Template
{
TemplateName = "Better Next Year",
CategoryID =43,
Description = "Open Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD3.png",
ImgHoz = "OT_Party_SD3.svg",
SvgVer = "OT_Party_SN3.svg",
SvgHoz = "OT_Party_SN3.svg"
},
new Template
{
TemplateName = "Our Success",
CategoryID =43,
Description = "Open Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD4.png",
ImgHoz = "OT_Party_SD4.svg",
SvgVer = "OT_Party_SN4.svg",
SvgHoz = "OT_Party_SN4.svg"
},
new Template
{
TemplateName = "Let's Grow Together",
CategoryID =43,
Description = "Open Sans",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD5.png",
ImgHoz = "OT_Party_SD5.svg",
SvgVer = "OT_Party_SN5.svg",
SvgHoz = "OT_Party_SN5.svg"
},
new Template
{
TemplateName = "Response For Bigger Thing",
CategoryID =43,
Description = "Quicksand",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD6.png",
ImgHoz = "OT_Party_SD6.svg",
SvgVer = "OT_Party_SN6.svg",
SvgHoz = "OT_Party_SN6.svg"
},
new Template
{
TemplateName = "Be An Adult",
CategoryID =43,
Description = "Quicksand",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD7.png",
ImgHoz = "OT_Party_SD7.svg",
SvgVer = "OT_Party_SN7.svg",
SvgHoz = "OT_Party_SN7.svg"
},
new Template
{
TemplateName = "Better Place Better Stay",
CategoryID =43,
Description = "Quicksand",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD8.png",
ImgHoz = "OT_Party_SD8.svg",
SvgVer = "OT_Party_SN8.svg",
SvgHoz = "OT_Party_SN8.svg"
},
new Template
{
TemplateName = "Enjoy Own Home",
CategoryID =43,
Description = "Quicksand",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD9.png",
ImgHoz = "OT_Party_SD9.svg",
SvgVer = "OT_Party_SN9.svg",
SvgHoz = "OT_Party_SN9.svg"
},
new Template
{
TemplateName = "New Place Be Slay",
CategoryID =43,
Description = "Quicksand",
Price = (float)0,
Discount = (float)0,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "OT_Party_PD10.png",
ImgHoz = "OT_Party_SD10.svg",
SvgVer = "OT_Party_SN10.svg",
SvgHoz = "OT_Party_SN10.svg"
},
new Template
{
TemplateName = "oneyear1",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD1.png",
ImgHoz = "BD_First_SD1.svg",
SvgVer = "BD_First_SN1.svg",
SvgHoz = "BD_First_SN1.svg"
},
new Template
{
TemplateName = "oneyear2",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD2.png",
ImgHoz = "BD_First_SD2.svg",
SvgVer = "BD_First_SN2.svg",
SvgHoz = "BD_First_SN2.svg"
},
new Template
{
TemplateName = "oneyear3",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD3.png",
ImgHoz = "BD_First_SD3.svg",
SvgVer = "BD_First_SN3.svg",
SvgHoz = "BD_First_SN3.svg"
},
new Template
{
TemplateName = "oneyear4",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD4.png",
ImgHoz = "BD_First_SD4.svg",
SvgVer = "BD_First_SN4.svg",
SvgHoz = "BD_First_SN4.svg"
},
new Template
{
TemplateName = "oneyear5",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD5.png",
ImgHoz = "BD_First_SD5.svg",
SvgVer = "BD_First_SN5.svg",
SvgHoz = "BD_First_SN5.svg"
},
new Template
{
TemplateName = "oneyear6",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD6.png",
ImgHoz = "BD_First_SD6.svg",
SvgVer = "BD_First_SN6.svg",
SvgHoz = "BD_First_SN6.svg"
},
new Template
{
TemplateName = "oneyear7",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD7.png",
ImgHoz = "BD_First_SD7.svg",
SvgVer = "BD_First_SN7.svg",
SvgHoz = "BD_First_SN7.svg"
},
new Template
{
TemplateName = "oneyear8",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD8.png",
ImgHoz = "BD_First_SD8.svg",
SvgVer = "BD_First_SN8.svg",
SvgHoz = "BD_First_SN8.svg"
},
new Template
{
TemplateName = "oneyear9",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD9.png",
ImgHoz = "BD_First_SD9.svg",
SvgVer = "BD_First_SN9.svg",
SvgHoz = "BD_First_SN9.svg"
},
new Template
{
TemplateName = "oneyear10",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD10.png",
ImgHoz = "BD_First_SD10.svg",
SvgVer = "BD_First_SN10.svg",
SvgHoz = "BD_First_SN10.svg"
},
new Template
{
TemplateName = "oneyear11",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD11.png",
ImgHoz = "BD_First_SD11.svg",
SvgVer = "BD_First_SN11.svg",
SvgHoz = "BD_First_SN11.svg"
},
new Template
{
TemplateName = "oneyear12",
CategoryID =1,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_First_PD12.png",
ImgHoz = "BD_First_SD12.svg",
SvgVer = "BD_First_SN12.svg",
SvgHoz = "BD_First_SN12.svg"
},
new Template
{
TemplateName = "Teenager1",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD1.png",
ImgHoz = "BD_Teen_SD1.svg",
SvgVer = "BD_Teen_SN1.svg",
SvgHoz = "BD_Teen_SN1.svg"
},
new Template
{
TemplateName = "Teenager2",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD2.png",
ImgHoz = "BD_Teen_SD2.svg",
SvgVer = "BD_Teen_SN2.svg",
SvgHoz = "BD_Teen_SN2.svg"
},
new Template
{
TemplateName = "Teenager3",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD3.png",
ImgHoz = "BD_Teen_SD3.svg",
SvgVer = "BD_Teen_SN3.svg",
SvgHoz = "BD_Teen_SN3.svg"
},
new Template
{
TemplateName = "Teenager4",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD4.png",
ImgHoz = "BD_Teen_SD4.svg",
SvgVer = "BD_Teen_SN4.svg",
SvgHoz = "BD_Teen_SN4.svg"
},
new Template
{
TemplateName = "Teenager5",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD5.png",
ImgHoz = "BD_Teen_SD5.svg",
SvgVer = "BD_Teen_SN5.svg",
SvgHoz = "BD_Teen_SN5.svg"
},
new Template
{
TemplateName = "Teenager6",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD6.png",
ImgHoz = "BD_Teen_SD6.svg",
SvgVer = "BD_Teen_SN6.svg",
SvgHoz = "BD_Teen_SN6.svg"
},
new Template
{
TemplateName = "Teenager7",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD7.png",
ImgHoz = "BD_Teen_SD7.svg",
SvgVer = "BD_Teen_SN7.svg",
SvgHoz = "BD_Teen_SN7.svg"
},
new Template
{
TemplateName = "Teenager8",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD8.png",
ImgHoz = "BD_Teen_SD8.svg",
SvgVer = "BD_Teen_SN8.svg",
SvgHoz = "BD_Teen_SN8.svg"
},
new Template
{
TemplateName = "Teenager9",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD9.png",
ImgHoz = "BD_Teen_SD9.svg",
SvgVer = "BD_Teen_SN9.svg",
SvgHoz = "BD_Teen_SN9.svg"
},
new Template
{
TemplateName = "Teenager10",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD10.png",
ImgHoz = "BD_Teen_SD10.svg",
SvgVer = "BD_Teen_SN10.svg",
SvgHoz = "BD_Teen_SN10.svg"
},
new Template
{
TemplateName = "Teenager11",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD11.png",
ImgHoz = "BD_Teen_SD11.svg",
SvgVer = "BD_Teen_SN11.svg",
SvgHoz = "BD_Teen_SN11.svg"
},
new Template
{
TemplateName = "Teenager12",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD12.png",
ImgHoz = "BD_Teen_SD12.svg",
SvgVer = "BD_Teen_SN12.svg",
SvgHoz = "BD_Teen_SN12.svg"
},
new Template
{
TemplateName = "Teenager13",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD13.png",
ImgHoz = "BD_Teen_SD13.svg",
SvgVer = "BD_Teen_SN13.svg",
SvgHoz = "BD_Teen_SN13.svg"
},
new Template
{
TemplateName = "Teenager14",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD14.png",
ImgHoz = "BD_Teen_SD14.svg",
SvgVer = "BD_Teen_SN14.svg",
SvgHoz = "BD_Teen_SN14.svg"
},
new Template
{
TemplateName = "Teenager15",
CategoryID =2,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Teen_PD15.png",
ImgHoz = "BD_Teen_SD15.svg",
SvgVer = "BD_Teen_SN15.svg",
SvgHoz = "BD_Teen_SN15.svg"
},
new Template
{
TemplateName = "Adult1",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD1.png",
ImgHoz = "BD_Adult_SD1.svg",
SvgVer = "BD_Adult_SN1.svg",
SvgHoz = "BD_Adult_SN1.svg"
},
new Template
{
TemplateName = "Adult2",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD2.png",
ImgHoz = "BD_Adult_SD2.svg",
SvgVer = "BD_Adult_SN2.svg",
SvgHoz = "BD_Adult_SN2.svg"
},
new Template
{
TemplateName = "Adult3",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD3.png",
ImgHoz = "BD_Adult_SD3.svg",
SvgVer = "BD_Adult_SN3.svg",
SvgHoz = "BD_Adult_SN3.svg"
},
new Template
{
TemplateName = "Adult4",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD4.png",
ImgHoz = "BD_Adult_SD4.svg",
SvgVer = "BD_Adult_SN4.svg",
SvgHoz = "BD_Adult_SN4.svg"
},
new Template
{
TemplateName = "Adult5",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD5.png",
ImgHoz = "BD_Adult_SD5.svg",
SvgVer = "BD_Adult_SN5.svg",
SvgHoz = "BD_Adult_SN5.svg"
},
new Template
{
TemplateName = "Adult6",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD6.png",
ImgHoz = "BD_Adult_SD6.svg",
SvgVer = "BD_Adult_SN6.svg",
SvgHoz = "BD_Adult_SN6.svg"
},
new Template
{
TemplateName = "Adult7",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD7.png",
ImgHoz = "BD_Adult_SD7.svg",
SvgVer = "BD_Adult_SN7.svg",
SvgHoz = "BD_Adult_SN7.svg"
},
new Template
{
TemplateName = "Adult8",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD8.png",
ImgHoz = "BD_Adult_SD8.svg",
SvgVer = "BD_Adult_SN8.svg",
SvgHoz = "BD_Adult_SN8.svg"
},
new Template
{
TemplateName = "Adult9",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD9.png",
ImgHoz = "BD_Adult_SD9.svg",
SvgVer = "BD_Adult_SN9.svg",
SvgHoz = "BD_Adult_SN9.svg"
},
new Template
{
TemplateName = "Adult10",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD10.png",
ImgHoz = "BD_Adult_SD10.svg",
SvgVer = "BD_Adult_SN10.svg",
SvgHoz = "BD_Adult_SN10.svg"
},
new Template
{
TemplateName = "Adult11",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD11.png",
ImgHoz = "BD_Adult_SD11.svg",
SvgVer = "BD_Adult_SN11.svg",
SvgHoz = "BD_Adult_SN11.svg"
},
new Template
{
TemplateName = "Adult12",
CategoryID =3,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Adult_PD12.png",
ImgHoz = "BD_Adult_SD12.svg",
SvgVer = "BD_Adult_SN12.svg",
SvgHoz = "BD_Adult_SN12.svg"
},
new Template
{
TemplateName = "Elder1",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD1.png",
ImgHoz = "BD_Edler_SD1.svg",
SvgVer = "BD_Edler_SN1.svg",
SvgHoz = "BD_Edler_SN1.svg"
},
new Template
{
TemplateName = "Elder2",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD2.png",
ImgHoz = "BD_Edler_SD2.svg",
SvgVer = "BD_Edler_SN2.svg",
SvgHoz = "BD_Edler_SN2.svg"
},
new Template
{
TemplateName = "Elder3",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD3.png",
ImgHoz = "BD_Edler_SD3.svg",
SvgVer = "BD_Edler_SN3.svg",
SvgHoz = "BD_Edler_SN3.svg"
},
new Template
{
TemplateName = "Elder4",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD4.png",
ImgHoz = "BD_Edler_SD4.svg",
SvgVer = "BD_Edler_SN4.svg",
SvgHoz = "BD_Edler_SN4.svg"
},
new Template
{
TemplateName = "Elder5",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD5.png",
ImgHoz = "BD_Edler_SD5.svg",
SvgVer = "BD_Edler_SN5.svg",
SvgHoz = "BD_Edler_SN5.svg"
},
new Template
{
TemplateName = "Elder6",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD6.png",
ImgHoz = "BD_Edler_SD6.svg",
SvgVer = "BD_Edler_SN6.svg",
SvgHoz = "BD_Edler_SN6.svg"
},
new Template
{
TemplateName = "Elder7",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD7.png",
ImgHoz = "BD_Edler_SD7.svg",
SvgVer = "BD_Edler_SN7.svg",
SvgHoz = "BD_Edler_SN7.svg"
},
new Template
{
TemplateName = "Elder8",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD8.png",
ImgHoz = "BD_Edler_SD8.svg",
SvgVer = "BD_Edler_SN8.svg",
SvgHoz = "BD_Edler_SN8.svg"
},
new Template
{
TemplateName = "Elder9",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD9.png",
ImgHoz = "BD_Edler_SD9.svg",
SvgVer = "BD_Edler_SN9.svg",
SvgHoz = "BD_Edler_SN9.svg"
},
new Template
{
TemplateName = "Elder10",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD10.png",
ImgHoz = "BD_Edler_SD10.svg",
SvgVer = "BD_Edler_SN10.svg",
SvgHoz = "BD_Edler_SN10.svg"
},
new Template
{
TemplateName = "Elder11",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD11.png",
ImgHoz = "BD_Edler_SD11.svg",
SvgVer = "BD_Edler_SN11.svg",
SvgHoz = "BD_Edler_SN11.svg"
},
new Template
{
TemplateName = "Elder12",
CategoryID =4,
Description = "",
Price = (float)1.5,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Edler_PD12.png",
ImgHoz = "BD_Edler_SD12.svg",
SvgVer = "BD_Edler_SN12.svg",
SvgHoz = "BD_Edler_SN12.svg"
},
new Template
{
TemplateName = "Cute1",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD1.png",
ImgHoz = "BD_Cute_SD1.svg",
SvgVer = "BD_Cute_SN1.svg",
SvgHoz = "BD_Cute_SN1.svg"
},
new Template
{
TemplateName = "Cute2",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD2.png",
ImgHoz = "BD_Cute_SD2.svg",
SvgVer = "BD_Cute_SN2.svg",
SvgHoz = "BD_Cute_SN2.svg"
},
new Template
{
TemplateName = "Cute3",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD3.png",
ImgHoz = "BD_Cute_SD3.svg",
SvgVer = "BD_Cute_SN3.svg",
SvgHoz = "BD_Cute_SN3.svg"
},
new Template
{
TemplateName = "Cute4",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD4.png",
ImgHoz = "BD_Cute_SD4.svg",
SvgVer = "BD_Cute_SN4.svg",
SvgHoz = "BD_Cute_SN4.svg"
},
new Template
{
TemplateName = "Cute5",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD5.png",
ImgHoz = "BD_Cute_SD5.svg",
SvgVer = "BD_Cute_SN5.svg",
SvgHoz = "BD_Cute_SN5.svg"
},
new Template
{
TemplateName = "Cute6",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD6.png",
ImgHoz = "BD_Cute_SD6.svg",
SvgVer = "BD_Cute_SN6.svg",
SvgHoz = "BD_Cute_SN6.svg"
},
new Template
{
TemplateName = "Cute7",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD7.png",
ImgHoz = "BD_Cute_SD7.svg",
SvgVer = "BD_Cute_SN7.svg",
SvgHoz = "BD_Cute_SN7.svg"
},
new Template
{
TemplateName = "Cute8",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD8.png",
ImgHoz = "BD_Cute_SD8.svg",
SvgVer = "BD_Cute_SN8.svg",
SvgHoz = "BD_Cute_SN8.svg"
},
new Template
{
TemplateName = "Cute9",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD9.png",
ImgHoz = "BD_Cute_SD9.svg",
SvgVer = "BD_Cute_SN9.svg",
SvgHoz = "BD_Cute_SN9.svg"
},
new Template
{
TemplateName = "Cute10",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD10.png",
ImgHoz = "BD_Cute_SD10.svg",
SvgVer = "BD_Cute_SN10.svg",
SvgHoz = "BD_Cute_SN10.svg"
},
new Template
{
TemplateName = "Cute11",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD11.png",
ImgHoz = "BD_Cute_SD11.svg",
SvgVer = "BD_Cute_SN11.svg",
SvgHoz = "BD_Cute_SN11.svg"
},
new Template
{
TemplateName = "Cute12",
CategoryID =6,
Description = "",
Price = (float)1.2,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Cute_PD12.png",
ImgHoz = "BD_Cute_SD12.svg",
SvgVer = "BD_Cute_SN12.svg",
SvgHoz = "BD_Cute_SN12.svg"
},
new Template
{
TemplateName = "Vintage1",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD1.png",
ImgHoz = "BD_Vintage_SD1.svg",
SvgVer = "BD_Vintage_SN1.svg",
SvgHoz = "BD_Vintage_SN1.svg"
},
new Template
{
TemplateName = "Vintage2",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD2.png",
ImgHoz = "BD_Vintage_SD2.svg",
SvgVer = "BD_Vintage_SN2.svg",
SvgHoz = "BD_Vintage_SN2.svg"
},
new Template
{
TemplateName = "Vintage3",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD3.png",
ImgHoz = "BD_Vintage_SD3.svg",
SvgVer = "BD_Vintage_SN3.svg",
SvgHoz = "BD_Vintage_SN3.svg"
},
new Template
{
TemplateName = "Vintage4",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD4.png",
ImgHoz = "BD_Vintage_SD4.svg",
SvgVer = "BD_Vintage_SN4.svg",
SvgHoz = "BD_Vintage_SN4.svg"
},
new Template
{
TemplateName = "Vintage5",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD5.png",
ImgHoz = "BD_Vintage_SD5.svg",
SvgVer = "BD_Vintage_SN5.svg",
SvgHoz = "BD_Vintage_SN5.svg"
},
new Template
{
TemplateName = "Vintage6",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD6.png",
ImgHoz = "BD_Vintage_SD6.svg",
SvgVer = "BD_Vintage_SN6.svg",
SvgHoz = "BD_Vintage_SN6.svg"
},
new Template
{
TemplateName = "Vintage7",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD7.png",
ImgHoz = "BD_Vintage_SD7.svg",
SvgVer = "BD_Vintage_SN7.svg",
SvgHoz = "BD_Vintage_SN7.svg"
},
new Template
{
TemplateName = "Vintage8",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD8.png",
ImgHoz = "BD_Vintage_SD8.svg",
SvgVer = "BD_Vintage_SN8.svg",
SvgHoz = "BD_Vintage_SN8.svg"
},
new Template
{
TemplateName = "Vintage9",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD9.png",
ImgHoz = "BD_Vintage_SD9.svg",
SvgVer = "BD_Vintage_SN9.svg",
SvgHoz = "BD_Vintage_SN9.svg"
},
new Template
{
TemplateName = "Vintage10",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD10.png",
ImgHoz = "BD_Vintage_SD10.svg",
SvgVer = "BD_Vintage_SN10.svg",
SvgHoz = "BD_Vintage_SN10.svg"
},
new Template
{
TemplateName = "Vintage11",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD11.png",
ImgHoz = "BD_Vintage_SD11.svg",
SvgVer = "BD_Vintage_SN11.svg",
SvgHoz = "BD_Vintage_SN11.svg"
},
new Template
{
TemplateName = "Vintage12",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD12.png",
ImgHoz = "BD_Vintage_SD12.svg",
SvgVer = "BD_Vintage_SN12.svg",
SvgHoz = "BD_Vintage_SN12.svg"
},
new Template
{
TemplateName = "Vintage13",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD13.png",
ImgHoz = "BD_Vintage_SD13.svg",
SvgVer = "BD_Vintage_SN13.svg",
SvgHoz = "BD_Vintage_SN13.svg"
},
new Template
{
TemplateName = "Vintage14",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD14.png",
ImgHoz = "BD_Vintage_SD14.svg",
SvgVer = "BD_Vintage_SN14.svg",
SvgHoz = "BD_Vintage_SN14.svg"
},
new Template
{
TemplateName = "Vintage15",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD15.png",
ImgHoz = "BD_Vintage_SD15.svg",
SvgVer = "BD_Vintage_SN15.svg",
SvgHoz = "BD_Vintage_SN15.svg"
},
new Template
{
TemplateName = "Vintage16",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD16.png",
ImgHoz = "BD_Vintage_PN16.png",
SvgVer = "BD_Vintage_SN16.SNg",
SvgHoz = "BD_Vintage_SN16.SNg"
},
new Template
{
TemplateName = "Vintage17",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD17.png",
ImgHoz = "BD_Vintage_PN17.png",
SvgVer = "BD_Vintage_SN17.SNg",
SvgHoz = "BD_Vintage_SN17.SNg"
},
new Template
{
TemplateName = "Vintage18",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD18.png",
ImgHoz = "BD_Vintage_PN18.png",
SvgVer = "BD_Vintage_SN18.SNg",
SvgHoz = "BD_Vintage_SN18.SNg"
},
new Template
{
TemplateName = "Vintage19",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD19.png",
ImgHoz = "BD_Vintage_PN19.png",
SvgVer = "BD_Vintage_SN19.SNg",
SvgHoz = "BD_Vintage_SN19.SNg"
},
new Template
{
TemplateName = "Vintage20",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD20.png",
ImgHoz = "BD_Vintage_PN20.png",
SvgVer = "BD_Vintage_SN20.SNg",
SvgHoz = "BD_Vintage_SN20.SNg"
},
new Template
{
TemplateName = "Vintage21",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD21.png",
ImgHoz = "BD_Vintage_PN21.png",
SvgVer = "BD_Vintage_SN21.SNg",
SvgHoz = "BD_Vintage_SN21.SNg"
},
new Template
{
TemplateName = "Vintage22",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD22.png",
ImgHoz = "BD_Vintage_PN22.png",
SvgVer = "BD_Vintage_SN22.SNg",
SvgHoz = "BD_Vintage_SN22.SNg"
},
new Template
{
TemplateName = "Vintage23",
CategoryID =11,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Vintage_PD23.png",
ImgHoz = "BD_Vintage_PN23.png",
SvgVer = "BD_Vintage_SN23.SNg",
SvgHoz = "BD_Vintage_SN23.SNg"
},
new Template
{
TemplateName = "Modern1",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD1.png",
ImgHoz = "BD_Mordern_SD1.svg",
SvgVer = "BD_Mordern_SN1.svg",
SvgHoz = "BD_Mordern_SN1.svg"
},
new Template
{
TemplateName = "Modern2",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD2.png",
ImgHoz = "BD_Mordern_SD2.svg",
SvgVer = "BD_Mordern_SN2.svg",
SvgHoz = "BD_Mordern_SN2.svg"
},
new Template
{
TemplateName = "Modern3",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD3.png",
ImgHoz = "BD_Mordern_SD3.svg",
SvgVer = "BD_Mordern_SN3.svg",
SvgHoz = "BD_Mordern_SN3.svg"
},
new Template
{
TemplateName = "Modern4",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD4.png",
ImgHoz = "BD_Mordern_SD4.svg",
SvgVer = "BD_Mordern_SN4.svg",
SvgHoz = "BD_Mordern_SN4.svg"
},
new Template
{
TemplateName = "Modern5",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD5.png",
ImgHoz = "BD_Mordern_SD5.svg",
SvgVer = "BD_Mordern_SN5.svg",
SvgHoz = "BD_Mordern_SN5.svg"
},
new Template
{
TemplateName = "Modern6",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD6.png",
ImgHoz = "BD_Mordern_SD6.svg",
SvgVer = "BD_Mordern_SN6.svg",
SvgHoz = "BD_Mordern_SN6.svg"
},
new Template
{
TemplateName = "Modern7",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD7.png",
ImgHoz = "BD_Mordern_SD7.svg",
SvgVer = "BD_Mordern_SN7.svg",
SvgHoz = "BD_Mordern_SN7.svg"
},
new Template
{
TemplateName = "Modern8",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD8.png",
ImgHoz = "BD_Mordern_SD8.svg",
SvgVer = "BD_Mordern_SN8.svg",
SvgHoz = "BD_Mordern_SN8.svg"
},
new Template
{
TemplateName = "Modern9",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD9.png",
ImgHoz = "BD_Mordern_SD9.svg",
SvgVer = "BD_Mordern_SN9.svg",
SvgHoz = "BD_Mordern_SN9.svg"
},
new Template
{
TemplateName = "Modern10",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD10.png",
ImgHoz = "BD_Mordern_SD10.svg",
SvgVer = "BD_Mordern_SN10.svg",
SvgHoz = "BD_Mordern_SN10.svg"
},
new Template
{
TemplateName = "Modern11",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD11.png",
ImgHoz = "BD_Mordern_SD11.svg",
SvgVer = "BD_Mordern_SN11.svg",
SvgHoz = "BD_Mordern_SN11.svg"
},
new Template
{
TemplateName = "Modern12",
CategoryID =9,
Description = "",
Price = (float)1.4,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Mordern_PD12.png",
ImgHoz = "BD_Mordern_SD12.svg",
SvgVer = "BD_Mordern_SN12.svg",
SvgHoz = "BD_Mordern_SN12.svg"
},
new Template
{
TemplateName = "Funny1",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD1.png",
ImgHoz = "BD_Funny_SD1.svg",
SvgVer = "BD_Funny_SN1.svg",
SvgHoz = "BD_Funny_SN1.svg"
},
new Template
{
TemplateName = "Funny2",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD2.png",
ImgHoz = "BD_Funny_SD2.svg",
SvgVer = "BD_Funny_SN2.svg",
SvgHoz = "BD_Funny_SN2.svg"
},
new Template
{
TemplateName = "Funny3",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD3.png",
ImgHoz = "BD_Funny_SD3.svg",
SvgVer = "BD_Funny_SN3.svg",
SvgHoz = "BD_Funny_SN3.svg"
},
new Template
{
TemplateName = "Funny4",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD4.png",
ImgHoz = "BD_Funny_SD4.svg",
SvgVer = "BD_Funny_SN4.svg",
SvgHoz = "BD_Funny_SN4.svg"
},
new Template
{
TemplateName = "Funny5",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD5.png",
ImgHoz = "BD_Funny_SD5.svg",
SvgVer = "BD_Funny_SN5.svg",
SvgHoz = "BD_Funny_SN5.svg"
},
new Template
{
TemplateName = "Funny6",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD6.png",
ImgHoz = "BD_Funny_SD6.svg",
SvgVer = "BD_Funny_SN6.svg",
SvgHoz = "BD_Funny_SN6.svg"
},
new Template
{
TemplateName = "Funny7",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD7.png",
ImgHoz = "BD_Funny_SD7.svg",
SvgVer = "BD_Funny_SN7.svg",
SvgHoz = "BD_Funny_SN7.svg"
},
new Template
{
TemplateName = "Funny8",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD8.png",
ImgHoz = "BD_Funny_SD8.svg",
SvgVer = "BD_Funny_SN8.svg",
SvgHoz = "BD_Funny_SN8.svg"
},
new Template
{
TemplateName = "Funny9",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD9.png",
ImgHoz = "BD_Funny_SD9.svg",
SvgVer = "BD_Funny_SN9.svg",
SvgHoz = "BD_Funny_SN9.svg"
},
new Template
{
TemplateName = "Funny10",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD10.png",
ImgHoz = "BD_Funny_SD10.svg",
SvgVer = "BD_Funny_SN10.svg",
SvgHoz = "BD_Funny_SN10.svg"
},
new Template
{
TemplateName = "Funny11",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD11.png",
ImgHoz = "BD_Funny_SD11.svg",
SvgVer = "BD_Funny_SN11.svg",
SvgHoz = "BD_Funny_SN11.svg"
},
new Template
{
TemplateName = "Funny12",
CategoryID =7,
Description = "",
Price = (float)1.3,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_Funny_PD12.png",
ImgHoz = "BD_Funny_SD12.svg",
SvgVer = "BD_Funny_SN12.svg",
SvgHoz = "BD_Funny_SN12.svg"
},
new Template
{
TemplateName = "General1",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD1.png",
ImgHoz = "BD_General_SD1.svg",
SvgVer = "BD_General_SN1.svg",
SvgHoz = "BD_General_SN1.svg"
},
new Template
{
TemplateName = "General2",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD2.png",
ImgHoz = "BD_General_SD2.svg",
SvgVer = "BD_General_SN2.svg",
SvgHoz = "BD_General_SN2.svg"
},
new Template
{
TemplateName = "General3",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD3.png",
ImgHoz = "BD_General_SD3.svg",
SvgVer = "BD_General_SN3.svg",
SvgHoz = "BD_General_SN3.svg"
},
new Template
{
TemplateName = "General4",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD4.png",
ImgHoz = "BD_General_SD4.svg",
SvgVer = "BD_General_SN4.svg",
SvgHoz = "BD_General_SN4.svg"
},
new Template
{
TemplateName = "General5",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD5.png",
ImgHoz = "BD_General_SD5.svg",
SvgVer = "BD_General_SN5.svg",
SvgHoz = "BD_General_SN5.svg"
},
new Template
{
TemplateName = "General6",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD6.png",
ImgHoz = "BD_General_SD6.svg",
SvgVer = "BD_General_SN6.svg",
SvgHoz = "BD_General_SN6.svg"
},
new Template
{
TemplateName = "General7",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD7.png",
ImgHoz = "BD_General_SD7.svg",
SvgVer = "BD_General_SN7.svg",
SvgHoz = "BD_General_SN7.svg"
},
new Template
{
TemplateName = "General8",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD8.png",
ImgHoz = "BD_General_SD8.svg",
SvgVer = "BD_General_SN8.svg",
SvgHoz = "BD_General_SN8.svg"
},
new Template
{
TemplateName = "General9",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD9.png",
ImgHoz = "BD_General_SD9.svg",
SvgVer = "BD_General_SN9.svg",
SvgHoz = "BD_General_SN9.svg"
},
new Template
{
TemplateName = "General10",
CategoryID =10,
Description = "",
Price = (float)1,
Discount = (float)0.5,
CreatedDate = DateTime.Parse("01/12/2024"),
Status = true,
ImgVer = "BD_General_PD10.png",
ImgHoz = "BD_General_SD10.svg",
SvgVer = "BD_General_SN10.svg",
SvgHoz = "BD_General_SN10.svg"
},




                };

                context.Templates.AddRange(templates);
                context.SaveChanges();
            }
        }
    }
}


