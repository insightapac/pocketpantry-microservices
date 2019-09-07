using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class MealPlanUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Filters",
                table: "MealPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUri",
                table: "MealPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "MealPlan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Filters",
                table: "MealPlan");

            migrationBuilder.DropColumn(
                name: "ImageUri",
                table: "MealPlan");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "MealPlan");
        }
    }
}
