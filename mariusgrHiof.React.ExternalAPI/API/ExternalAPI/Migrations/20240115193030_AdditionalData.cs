using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ExternalAPI.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WikiLink",
                table: "Cars",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "WikiLink" },
                values: new object[] { "The Skyline R34 GT-R is an iconic Japanese sports car celebrated for its powerful performance and sleek design. Equipped with a twin-turbocharged inline-six engine, advanced all-wheel-drive system, and distinctive body styling, the R34 is revered among automotive enthusiasts for its dominance on the track and timeless appeal. Its legendary status is further solidified by its starring role in motorsport and popular culture.", "https://speedhunters-wp-production.s3.amazonaws.com/wp-content/uploads/2021/07/20205450/Speedhunters_R34roller-3-1200x800.jpg", "https://en.wikipedia.org/wiki/Nissan_Skyline_GT-R" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "WikiLink" },
                values: new object[] { "The Nissan 350Z is a dynamic and stylish sports car that gained popularity for its engaging driving experience. With a potent V6 engine, rear-wheel drive, and a well-tuned suspension, the 350Z delivers a thrilling performance. Its distinctive design, characterized by a sleek profile and bold curves, contributes to its enduring appeal as a modern classic in the automotive world.", "https://hips.hearstapps.com/hmg-prod/images/350rear-1513348241.jpeg", "https://en.wikipedia.org/wiki/Nissan_350Z" });

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "WikiLink" },
                values: new object[] { "The Nissan 200SX, part of the S platform series, is a compact and sporty coupe that gained acclaim for its agile handling and performance. With a focus on rear-wheel drive dynamics, it featured various engine options over its production years, delivering a balance of power and efficiency. Recognized for its sleek and aerodynamic design, the Nissan 200SX remains a beloved choice among enthusiasts for its sporty appeal and tunable capabilities.", "https://i.redd.it/tudob7j67ev41.jpg", "https://en.wikipedia.org/wiki/Nissan_200SX" });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Description", "Hp", "ImageUrl", "Make", "Model", "WikiLink", "YearOfRelease" },
                values: new object[,]
                {
                    { 4, "The Toyota Supra MK4, an automotive legend, is a high-performance sports car celebrated for its powerful 2JZ inline-six engine, rear-wheel-drive layout, and iconic styling. Renowned for its prowess on both the street and the racetrack, the Supra MK4 has achieved cult status among enthusiasts. Its combination of cutting-edge technology, striking design, and exceptional performance has solidified its place as one of the most revered and sought-after sports cars in automotive history.", 1200, "https://ronbrooks.b-cdn.net/wp-content/uploads/2023/06/toyota-supra-mk4.png", "Toyota", "Supra MK4", "https://en.wikipedia.org/wiki/Toyota_Supra", 1999 },
                    { 5, "The Toyota AE86, a cult classic, is a compact rear-wheel-drive sports car celebrated for its lightweight chassis and nimble handling. Produced in the mid-1980s, it gained fame through motorsports, particularly in drifting. The AE86, part of the Corolla Levin and Sprinter Trueno lineup, is powered by a 4A-GE engine, and its iconic pop-up headlights and timeless design contribute to its enduring popularity among automotive enthusiasts.", 180, "https://cdn.arstechnica.net/wp-content/uploads/2023/01/20230113_01_01_s.jpg", "Toytoa", "Sprinter Trueno AE86", "https://en.wikipedia.org/wiki/Toyota_AE86", 1998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Cars");

            migrationBuilder.DropColumn(
                name: "WikiLink",
                table: "Cars");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "ImageUrl",
                value: "someurl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "someurl");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "someurl");
        }
    }
}
