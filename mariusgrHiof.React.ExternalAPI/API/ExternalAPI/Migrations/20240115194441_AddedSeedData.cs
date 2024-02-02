using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ExternalAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The Nissan Skyline R34 GT-R is an iconic Japanese sports car renowned for its potent twin-turbo inline-six and timeless design. The Toyota Supra MK4, featuring the legendary 2JZ engine, stands as a symbol of high-performance excellence and distinctive styling in automotive history.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The Nissan 350Z delivers a thrilling driving experience with its powerful V6 engine and rear-wheel-drive configuration, while its sleek design and bold curves contribute to its enduring appeal as a modern classic in the world of sports cars.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "The Nissan 200SX, part of the S platform series, is a compact and sporty coupe celebrated for its agile handling and varied engine options, offering a balance of power and efficiency. Recognized for its sleek, aerodynamic design, the 200SX remains a beloved choice among enthusiasts for its sporty appeal and tunable capabilities.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "The Toyota Supra MK4, an automotive legend, is distinguished by its powerful 2JZ inline-six engine, rear-wheel-drive layout, and iconic styling. Renowned for its exceptional performance on both the street and the racetrack, the Supra MK4 has achieved cult status among enthusiasts for its cutting-edge technology and enduring appeal.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "The Toyota AE86, a compact and nimble sports car, is celebrated for its lightweight chassis and agile handling, particularly in drifting culture. Part of the Corolla Levin and Sprinter Trueno lineup, the AE86's iconic design and association with motorsports have solidified its status as a cult classic among automotive enthusiasts.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "The Skyline R34 GT-R is an iconic Japanese sports car celebrated for its powerful performance and sleek design. Equipped with a twin-turbocharged inline-six engine, advanced all-wheel-drive system, and distinctive body styling, the R34 is revered among automotive enthusiasts for its dominance on the track and timeless appeal. Its legendary status is further solidified by its starring role in motorsport and popular culture.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The Nissan 350Z is a dynamic and stylish sports car that gained popularity for its engaging driving experience. With a potent V6 engine, rear-wheel drive, and a well-tuned suspension, the 350Z delivers a thrilling performance. Its distinctive design, characterized by a sleek profile and bold curves, contributes to its enduring appeal as a modern classic in the automotive world.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3,
                column: "Description",
                value: "The Nissan 200SX, part of the S platform series, is a compact and sporty coupe that gained acclaim for its agile handling and performance. With a focus on rear-wheel drive dynamics, it featured various engine options over its production years, delivering a balance of power and efficiency. Recognized for its sleek and aerodynamic design, the Nissan 200SX remains a beloved choice among enthusiasts for its sporty appeal and tunable capabilities.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4,
                column: "Description",
                value: "The Toyota Supra MK4, an automotive legend, is a high-performance sports car celebrated for its powerful 2JZ inline-six engine, rear-wheel-drive layout, and iconic styling. Renowned for its prowess on both the street and the racetrack, the Supra MK4 has achieved cult status among enthusiasts. Its combination of cutting-edge technology, striking design, and exceptional performance has solidified its place as one of the most revered and sought-after sports cars in automotive history.");

            migrationBuilder.UpdateData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5,
                column: "Description",
                value: "The Toyota AE86, a cult classic, is a compact rear-wheel-drive sports car celebrated for its lightweight chassis and nimble handling. Produced in the mid-1980s, it gained fame through motorsports, particularly in drifting. The AE86, part of the Corolla Levin and Sprinter Trueno lineup, is powered by a 4A-GE engine, and its iconic pop-up headlights and timeless design contribute to its enduring popularity among automotive enthusiasts.");
        }
    }
}
