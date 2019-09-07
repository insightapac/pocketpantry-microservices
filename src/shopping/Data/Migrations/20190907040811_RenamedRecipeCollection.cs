using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Shopping.Migrations
{
    public partial class RenamedRecipeCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_RecipeCategory_RecipeCategoryId",
                table: "Recipe");

            migrationBuilder.DropTable(
                name: "RecipeCategory");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_RecipeCollection_RecipeCategoryId",
                table: "Recipe",
                column: "RecipeCategoryId",
                principalTable: "RecipeCollection",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_RecipeCollection_RecipeCategoryId",
                table: "Recipe");

            migrationBuilder.DropTable(
                name: "RecipeCollection");

            migrationBuilder.CreateTable(
                name: "RecipeCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCategory", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_RecipeCategory_RecipeCategoryId",
                table: "Recipe",
                column: "RecipeCategoryId",
                principalTable: "RecipeCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
