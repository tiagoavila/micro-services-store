using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Infra.Migrations
{
    public partial class InitialVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    AvailableStock = table.Column<int>(nullable: false),
                    ImageUrl = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableStock", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("996f4a78-0324-468b-b31a-73935130139b"), 50, "Guitarra Ibanex GRG220 Preta", "https://http2.mlstatic.com/guitarra-electrica-ibanez-gio-grg220dex-D_NQ_NP_760329-MLV27359093213_052018-F.jpg", 1200m, "Guitarra Ibanex GRG220" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableStock", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("542cc48f-215a-4cd6-be5a-ae2f9bd40eeb"), 50, "Samsung s9", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRh_iIgH_ErtqFO1tiMpysB3Z5VeJUjaThLCtKkajwXA_V4GXkp", 2000m, "Celular S9" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableStock", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { new Guid("b445a6a2-770c-48d2-a769-56231a9a99c7"), 50, "Kindle new generation", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHmy5pzaQxrs4nzLNXP0Ca-1zkBgzfLCwOMjxmDFDx02FGSzI6", 200m, "Kindle" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
