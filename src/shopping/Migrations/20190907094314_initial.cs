using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FoodItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItem", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ObjectID = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PreperationTime = table.Column<int>(nullable: false),
                    CookTime = table.Column<int>(nullable: false),
                    Servings = table.Column<int>(nullable: false),
                    Difficulty = table.Column<byte[]>(maxLength: 50, nullable: false),
                    Energy = table.Column<int>(nullable: false),
                    FatTotal = table.Column<double>(nullable: false),
                    SaturatedFat = table.Column<double>(nullable: false),
                    Fibre = table.Column<double>(nullable: false),
                    Protein = table.Column<double>(nullable: false),
                    Sodium = table.Column<double>(nullable: false),
                    CarbsSugar = table.Column<double>(nullable: false),
                    CarbsTotal = table.Column<double>(nullable: false),
                    NumIngredients = table.Column<int>(nullable: false),
                    RecipeCategoryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.ID);
                    table.ForeignKey(
                        name: "FK_44",
                        column: x => x.RecipeCategoryID,
                        principalTable: "Category",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AllergieFoodItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    FoodItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergieFoodItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_121",
                        column: x => x.FoodItemID,
                        principalTable: "FoodItem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_118",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MealPlan",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlan", x => x.ID);
                    table.ForeignKey(
                        name: "FK_102",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Pantry",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    LastUpdated = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pantry", x => x.ID);
                    table.ForeignKey(
                        name: "FK_20",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingList",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingList", x => x.ID);
                    table.ForeignKey(
                        name: "FK_12",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeSteps",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RecipeID = table.Column<int>(nullable: false),
                    StepNumber = table.Column<int>(nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeSteps", x => x.ID);
                    table.ForeignKey(
                        name: "FK_94",
                        column: x => x.RecipeID,
                        principalTable: "Recipe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MealPLanRecipe",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    MealPlanID = table.Column<int>(nullable: false),
                    RecipeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPLanRecipe", x => x.ID);
                    table.ForeignKey(
                        name: "FK_109",
                        column: x => x.MealPlanID,
                        principalTable: "MealPlan",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_112",
                        column: x => x.RecipeID,
                        principalTable: "Recipe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PantryItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    PantryID = table.Column<int>(nullable: false),
                    FoodItemID = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PantryItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_71",
                        column: x => x.FoodItemID,
                        principalTable: "FoodItem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_68",
                        column: x => x.PantryID,
                        principalTable: "Pantry",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ShoppingListITem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    ShoppingListID = table.Column<int>(nullable: false),
                    Qty = table.Column<double>(nullable: false),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    FoodItemID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShoppingListITem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_65",
                        column: x => x.FoodItemID,
                        principalTable: "FoodItem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_54",
                        column: x => x.ShoppingListID,
                        principalTable: "ShoppingList",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RecipeItem",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false),
                    RecipeID = table.Column<int>(nullable: false),
                    FoodItemID = table.Column<int>(nullable: false),
                    PantryItemID = table.Column<int>(nullable: false),
                    Qty = table.Column<int>(nullable: false),
                    Unit = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Note = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeItem", x => x.ID);
                    table.ForeignKey(
                        name: "FK_82",
                        column: x => x.FoodItemID,
                        principalTable: "FoodItem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_85",
                        column: x => x.PantryItemID,
                        principalTable: "PantryItem",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_79",
                        column: x => x.RecipeID,
                        principalTable: "Recipe",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "fkIdx_121",
                table: "AllergieFoodItem",
                column: "FoodItemID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_118",
                table: "AllergieFoodItem",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_102",
                table: "MealPlan",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_109",
                table: "MealPLanRecipe",
                column: "MealPlanID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_112",
                table: "MealPLanRecipe",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_20",
                table: "Pantry",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_71",
                table: "PantryItem",
                column: "FoodItemID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_68",
                table: "PantryItem",
                column: "PantryID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_44",
                table: "Recipe",
                column: "RecipeCategoryID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_82",
                table: "RecipeItem",
                column: "FoodItemID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_85",
                table: "RecipeItem",
                column: "PantryItemID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_79",
                table: "RecipeItem",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_94",
                table: "RecipeSteps",
                column: "RecipeID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_12",
                table: "ShoppingList",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_65",
                table: "ShoppingListITem",
                column: "FoodItemID");

            migrationBuilder.CreateIndex(
                name: "fkIdx_54",
                table: "ShoppingListITem",
                column: "ShoppingListID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllergieFoodItem");

            migrationBuilder.DropTable(
                name: "MealPLanRecipe");

            migrationBuilder.DropTable(
                name: "RecipeItem");

            migrationBuilder.DropTable(
                name: "RecipeSteps");

            migrationBuilder.DropTable(
                name: "ShoppingListITem");

            migrationBuilder.DropTable(
                name: "MealPlan");

            migrationBuilder.DropTable(
                name: "PantryItem");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "ShoppingList");

            migrationBuilder.DropTable(
                name: "FoodItem");

            migrationBuilder.DropTable(
                name: "Pantry");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
