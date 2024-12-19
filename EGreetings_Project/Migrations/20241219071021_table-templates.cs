using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EGreetings_Project.Migrations
{
    /// <inheritdoc />
    public partial class tabletemplates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    TemplatesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TemplateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Discount = table.Column<double>(type: "float", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: true, defaultValueSql: "GETDATE()"),
                    Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    ImgVer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImgHoz = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SVGVer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SVGHoz = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.TemplatesID);
                    table.ForeignKey(
                        name: "FK_Templates_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Templates_CategoryID",
                table: "Templates",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Templates");
        }
    }
}
