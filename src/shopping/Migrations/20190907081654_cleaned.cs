using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class cleaned : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pantry_User_UserId",
                table: "Pantry");

            migrationBuilder.DropForeignKey(
                name: "FK_PantryItem_FoodItem_FoodItemID",
                table: "PantryItem");

            migrationBuilder.DropForeignKey(
                name: "FK_RecipeItem_FoodItem_FoodItemID",
                table: "RecipeItem");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingList_User_UserId",
                table: "ShoppingList");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingListItem_FoodItem_FoodItemID",
                table: "ShoppingListItem");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingListItem_FoodItemID",
                table: "ShoppingListItem");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingList_UserId",
                table: "ShoppingList");

            migrationBuilder.DropIndex(
                name: "IX_RecipeItem_FoodItemID",
                table: "RecipeItem");

            migrationBuilder.DropIndex(
                name: "IX_PantryItem_FoodItemID",
                table: "PantryItem");

            migrationBuilder.DropIndex(
                name: "IX_Pantry_UserId",
                table: "Pantry");

            migrationBuilder.RenameColumn(
                name: "FoodItemID",
                table: "ShoppingListItem",
                newName: "Qty");

            migrationBuilder.RenameColumn(
                name: "FoodItemID",
                table: "RecipeItem",
                newName: "Qty");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "PantryItem",
                newName: "Unit");

            migrationBuilder.RenameColumn(
                name: "FoodItemID",
                table: "PantryItem",
                newName: "Qty");

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "ShoppingListItem",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ShoppingList",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Note",
                table: "RecipeItem",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Unit",
                table: "RecipeItem",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Pantry",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "AllergieFoodItemId",
                table: "FoodItem",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PantryItemId",
                table: "FoodItem",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RecipeItemId",
                table: "FoodItem",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShoppingListItemId",
                table: "FoodItem",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AllergieFoodItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergieFoodItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AllergieFoodItem_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_UserId",
                table: "ShoppingList",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Pantry_UserId",
                table: "Pantry",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItem_AllergieFoodItemId",
                table: "FoodItem",
                column: "AllergieFoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItem_PantryItemId",
                table: "FoodItem",
                column: "PantryItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItem_RecipeItemId",
                table: "FoodItem",
                column: "RecipeItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItem_ShoppingListItemId",
                table: "FoodItem",
                column: "ShoppingListItemId");

            migrationBuilder.CreateIndex(
                name: "IX_AllergieFoodItem_UserId",
                table: "AllergieFoodItem",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItem_AllergieFoodItem_AllergieFoodItemId",
                table: "FoodItem",
                column: "AllergieFoodItemId",
                principalTable: "AllergieFoodItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItem_PantryItem_PantryItemId",
                table: "FoodItem",
                column: "PantryItemId",
                principalTable: "PantryItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItem_RecipeItem_RecipeItemId",
                table: "FoodItem",
                column: "RecipeItemId",
                principalTable: "RecipeItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItem_ShoppingListItem_ShoppingListItemId",
                table: "FoodItem",
                column: "ShoppingListItemId",
                principalTable: "ShoppingListItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pantry_User_UserId",
                table: "Pantry",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingList_User_UserId",
                table: "ShoppingList",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItem_AllergieFoodItem_AllergieFoodItemId",
                table: "FoodItem");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodItem_PantryItem_PantryItemId",
                table: "FoodItem");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodItem_RecipeItem_RecipeItemId",
                table: "FoodItem");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodItem_ShoppingListItem_ShoppingListItemId",
                table: "FoodItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Pantry_User_UserId",
                table: "Pantry");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingList_User_UserId",
                table: "ShoppingList");

            migrationBuilder.DropTable(
                name: "AllergieFoodItem");

            migrationBuilder.DropIndex(
                name: "IX_ShoppingList_UserId",
                table: "ShoppingList");

            migrationBuilder.DropIndex(
                name: "IX_Pantry_UserId",
                table: "Pantry");

            migrationBuilder.DropIndex(
                name: "IX_FoodItem_AllergieFoodItemId",
                table: "FoodItem");

            migrationBuilder.DropIndex(
                name: "IX_FoodItem_PantryItemId",
                table: "FoodItem");

            migrationBuilder.DropIndex(
                name: "IX_FoodItem_RecipeItemId",
                table: "FoodItem");

            migrationBuilder.DropIndex(
                name: "IX_FoodItem_ShoppingListItemId",
                table: "FoodItem");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "ShoppingListItem");

            migrationBuilder.DropColumn(
                name: "Note",
                table: "RecipeItem");

            migrationBuilder.DropColumn(
                name: "Unit",
                table: "RecipeItem");

            migrationBuilder.DropColumn(
                name: "AllergieFoodItemId",
                table: "FoodItem");

            migrationBuilder.DropColumn(
                name: "PantryItemId",
                table: "FoodItem");

            migrationBuilder.DropColumn(
                name: "RecipeItemId",
                table: "FoodItem");

            migrationBuilder.DropColumn(
                name: "ShoppingListItemId",
                table: "FoodItem");

            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "ShoppingListItem",
                newName: "FoodItemID");

            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "RecipeItem",
                newName: "FoodItemID");

            migrationBuilder.RenameColumn(
                name: "Unit",
                table: "PantryItem",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "PantryItem",
                newName: "FoodItemID");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "ShoppingList",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Pantry",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingListItem_FoodItemID",
                table: "ShoppingListItem",
                column: "FoodItemID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ShoppingList_UserId",
                table: "ShoppingList",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RecipeItem_FoodItemID",
                table: "RecipeItem",
                column: "FoodItemID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PantryItem_FoodItemID",
                table: "PantryItem",
                column: "FoodItemID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pantry_UserId",
                table: "Pantry",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pantry_User_UserId",
                table: "Pantry",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PantryItem_FoodItem_FoodItemID",
                table: "PantryItem",
                column: "FoodItemID",
                principalTable: "FoodItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RecipeItem_FoodItem_FoodItemID",
                table: "RecipeItem",
                column: "FoodItemID",
                principalTable: "FoodItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingList_User_UserId",
                table: "ShoppingList",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingListItem_FoodItem_FoodItemID",
                table: "ShoppingListItem",
                column: "FoodItemID",
                principalTable: "FoodItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
