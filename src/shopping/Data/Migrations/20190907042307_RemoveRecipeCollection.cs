using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class RemoveRecipeCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_RecipeCollection_RecipeCategoryId",
                table: "Recipe");

            migrationBuilder.DropTable(
                name: "RecipeCollection");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_RecipeCategoryId",
                table: "Recipe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RecipeCollection",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCollection", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_RecipeCategoryId",
                table: "Recipe",
                column: "RecipeCategoryId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_RecipeCollection_RecipeCategoryId",
                table: "Recipe",
                column: "RecipeCategoryId",
                principalTable: "RecipeCollection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
