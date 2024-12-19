using EGreetings_Project.Models;
using EGreetings_Project.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;


namespace EGreetings_Project.Data.Seeder
{
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
                        CategoryID = 11,
                        Description = "Great Vibes, Fraunces, Alex Brush",
                        Price = 1.0f,
                        Discount = 0.1f,
                        CreatedDate = DateTime.Parse("01/01/2024"),
                        Status = true,
                        ImgVer = "WD-Vintage-D1I.png",
                        ImgHoz = "WD-Vintage-N1I.png",
                        SVGVer = "WD-Vintage-D1S.png",
                        SVGHoz = "WD-Vintage-N1S.png"
                    },
                    new Template
                    {
                        TemplateName = "Vintage White Rose",
                        CategoryID = 11,
                        Description = "Eyesome Script, Cinzel Decorative",
                        Price = 1.0f,
                        Discount = 0.1f,
                        CreatedDate = DateTime.Parse("01/01/2024"),
                        Status = true,
                        ImgVer = "WD-Vintage-D2I.png",
                        ImgHoz = "WD-Vintage-N2I.png",
                        SVGVer = "WD-Vintage-D2S.png",
                        SVGHoz = "WD-Vintage-N2S.png"
                    },
                    new Template
            {
                TemplateName = "Lavi en rose",
                CategoryID = 11,
                Description = "",  // Không có mô tả, có thể bổ sung sau
                Price = 1.0f,
                Discount = 0.2f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "WD-Vintage-D3I.png",
                ImgHoz = "WD-Vintage-N3I.png",
                SVGVer = "WD-Vintage-D3S.png",
                SVGHoz = "WD-Vintage-N3S.png"
            },
                    // Thêm các template khác vào đây
                    new Template
                    {
                        TemplateName = "Fes MidAutumn 1",
                        CategoryID = 30,
                        Description = "Berkshire Swash, Hero",
                        Price = 1.0f,
                        Discount = 0.0f,
                        CreatedDate = DateTime.Parse("01/01/2024"),
                        Status = true,
                        ImgVer = "Fes_MidAut_PD1.png",
                        ImgHoz = "Fes_MidAut_PN1.png",
                        SVGVer = "Fes_MidAut_SD1.png",
                        SVGHoz = "Fes_MidAut_SN1.png"
                    },
                    new Template
                    {
                        TemplateName = "Fes MidAutumn 2",
                        CategoryID = 30,
                        Description = "Berkshire Swash, Hero",
                        Price = 1.0f,
                        Discount = 0.0f,
                        CreatedDate = DateTime.Parse("01/01/2024"),
                        Status = true,
                        ImgVer = "Fes_MidAut_PD2.png",
                        ImgHoz = "Fes_MidAut_PN2.png",
                        SVGVer = "Fes_MidAut_SD2.png",
                        SVGHoz = "Fes_MidAut_SN2.png"
                    },
                   
            new Template
            {
                TemplateName = "Fes MidAutumn 3",
                CategoryID = 30,
                Description = "Berkshire Swash, Hero",
                Price = 1.0f,
                Discount = 0.0f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD3.png",
                ImgHoz = "Fes_MidAut_PN3.png",
                SVGVer = "Fes_MidAut_SD3.png",
                SVGHoz = "Fes_MidAut_SN3.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 4",
                CategoryID = 30,
                Description = "Glacial Indifference",
                Price = 1.0f,
                Discount = 0.0f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD4.png",
                ImgHoz = "Fes_MidAut_PN4.png",
                SVGVer = "Fes_MidAut_SD4.png",
                SVGHoz = "Fes_MidAut_SN4.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 5",
                CategoryID = 30,
                Description = "Tex Gyre Bonum",
                Price = 1.0f,
                Discount = 0.0f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD5.png",
                ImgHoz = "Fes_MidAut_PN5.png",
                SVGVer = "Fes_MidAut_SD5.png",
                SVGHoz = "Fes_MidAut_SN5.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 6",
                CategoryID = 30,
                Description = "Caveat Brush",
                Price = 1.0f,
                Discount = 0.0f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD6.png",
                ImgHoz = "Fes_MidAut_PN6.png",
                SVGVer = "Fes_MidAut_SD6.png",
                SVGHoz = "Fes_MidAut_SN6.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 7",
                CategoryID = 30,
                Description = "Crave Sans",
                Price = 1.0f,
                Discount = 0.0f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD7.png",
                ImgHoz = "Fes_MidAut_PN7.png",
                SVGVer = "Fes_MidAut_SD7.png",
                SVGHoz = "Fes_MidAut_SN7.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 8",
                CategoryID = 30,
                Description = "Berkshire Swash, Hero",
                Price = 1.0f,
                Discount = 0.0f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD8.png",
                ImgHoz = "Fes_MidAut_PN8.png",
                SVGVer = "Fes_MidAut_SD8.png",
                SVGHoz = "Fes_MidAut_SN8.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 9",
                CategoryID = 30,
                Description = "Berkshire Swash, Hero",
                Price = 1.0f,
                Discount = 0.0f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD9.png",
                ImgHoz = "Fes_MidAut_PN9.png",
                SVGVer = "Fes_MidAut_SD9.png",
                SVGHoz = "Fes_MidAut_SN9.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 10",
                CategoryID = 30,
                Description = "Berkshire Swash, Hero",
                Price = 1.0f,
                Discount = 0.0f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD10.png",
                ImgHoz = "Fes_MidAut_PN10.png",
                SVGVer = "Fes_MidAut_SD10.png",
                SVGHoz = "Fes_MidAut_SN10.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 11",
                CategoryID = 30,
                Description = "Crave Sans",
                Price = 1.0f,
                Discount = 0.19f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD11.png",
                ImgHoz = "Fes_MidAut_PN11.png",
                SVGVer = "Fes_MidAut_SD11.png",
                SVGHoz = "Fes_MidAut_SN11.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 12",
                CategoryID = 30,
                Description = "Amaranth",
                Price = 1.0f,
                Discount = 0.15f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD12.png",
                ImgHoz = "Fes_MidAut_PN12.png",
                SVGVer = "Fes_MidAut_SD12.png",
                SVGHoz = "Fes_MidAut_SN12.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 13",
                CategoryID = 30,
                Description = "Tex Gyre Bonum, Roca One",
                Price = 1.0f,
                Discount = 0.5f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD13.png",
                ImgHoz = "Fes_MidAut_PN15.png",
                SVGVer = "Fes_MidAut_SD13.png",
                SVGHoz = "Fes_MidAut_SN13.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 14",
                CategoryID = 30,
                Description = "Trocchi",
                Price = 1.0f,
                Discount = 0.3f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD14.png",
                ImgHoz = "Fes_MidAut_PN14.png",
                SVGVer = "Fes_MidAut_SD14.png",
                SVGHoz = "Fes_MidAut_SN14.png"
            },
            new Template
            {
                TemplateName = "Fes MidAutumn 15",
                CategoryID = 30,
                Description = "Tex Gyre Bonum, Now",
                Price = 1.0f,
                Discount = 0.2f,
                CreatedDate = DateTime.Parse("01/01/2024"),
                Status = true,
                ImgVer = "Fes_MidAut_PD15.png",
                ImgHoz = "Fes_MidAut_PN15.png",
                SVGVer = "Fes_MidAut_SD15.png",
                SVGHoz = "Fes_MidAut_SN15.png"
            }

                };

                    context.Templates.AddRange(templates);
                    context.SaveChanges();
                }
            }
        }
    }


