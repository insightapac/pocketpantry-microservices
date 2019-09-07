using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class datatypefix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Filters",
                table: "MealPlan");

            migrationBuilder.DropColumn(
                name: "ImageUri",
                table: "MealPlan");

            migrationBuilder.AlterColumn<string>(
                name: "Qty",
                table: "ShoppingListITem",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Qty",
                table: "RecipeItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Sodium",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Servings",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "SaturatedFat",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Protein",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "PreperationTime",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Fibre",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "FatTotal",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Energy",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "Difficulty",
                table: "Recipe",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(byte[]),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "CookTime",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "CarbsTotal",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "CarbsSugar",
                table: "Recipe",
                nullable: true,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<string>(
                name: "Qty",
                table: "PantryItem",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Filters",
                table: "Category",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUri",
                table: "Category",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Filters",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ImageUri",
                table: "Category");

            migrationBuilder.AlterColumn<double>(
                name: "Qty",
                table: "ShoppingListITem",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "RecipeItem",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Sodium",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Servings",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "SaturatedFat",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Protein",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PreperationTime",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Fibre",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "FatTotal",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Energy",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<byte[]>(
                name: "Difficulty",
                table: "Recipe",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "CookTime",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "CarbsTotal",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "CarbsSugar",
                table: "Recipe",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Qty",
                table: "PantryItem",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Filters",
                table: "MealPlan",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUri",
                table: "MealPlan",
                nullable: true);
        }
    }
}
