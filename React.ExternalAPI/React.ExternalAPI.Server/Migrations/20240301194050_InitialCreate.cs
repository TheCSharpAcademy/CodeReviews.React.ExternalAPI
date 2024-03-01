using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace React.ExternalAPI.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hitters",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BattingAverage = table.Column<double>(type: "float", nullable: false),
                    HomeRuns = table.Column<int>(type: "int", nullable: false),
                    RunsBattedIn = table.Column<int>(type: "int", nullable: false),
                    OnBasePercentage = table.Column<double>(type: "float", nullable: false),
                    SluggingPercentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hitters", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hitters");
        }
    }
}
