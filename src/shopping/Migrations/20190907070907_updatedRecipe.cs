using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class updatedRecipe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "CookingTime",
                table: "Recipe",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "DifficultyLevel",
                table: "Recipe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUri",
                table: "Recipe",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RecipeDescription",
                table: "Recipe",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "TotalCost",
                table: "Recipe",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "ImageUri",
                table: "MealPlan",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CookingTime",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "DifficultyLevel",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "ImageUri",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "RecipeDescription",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "ImageUri",
                table: "MealPlan");
        }
    }
}
