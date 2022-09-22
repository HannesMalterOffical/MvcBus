using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcBus.Migrations
{
    public partial class Speed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Speed",
                table: "Bus",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Speed",
                table: "Bus");
        }
    }
}
