using Microsoft.EntityFrameworkCore.Migrations;

namespace AutomobileLibreri.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarID = table.Column<int>(type: "int", nullable: false),
                    CarName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Manufacturer = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "money", nullable: false),
                    ReleasedYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
