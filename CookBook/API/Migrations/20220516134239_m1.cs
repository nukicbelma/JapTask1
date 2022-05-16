using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppUser",
                columns: table => new
                {
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Username = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUser", x => x.AppUserId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Ingredient",
                columns: table => new
                {
                    IngredientId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitMeasure = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredient", x => x.IngredientId);
                });

            migrationBuilder.CreateTable(
                name: "Recipe",
                columns: table => new
                {
                    RecipeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipe", x => x.RecipeId);
                    table.ForeignKey(
                        name: "FK_Recipe_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RecipeDetail",
                columns: table => new
                {
                    RecipteDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecipeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitMeasure = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__RecipeDe__C8C9B68C715ACE4B", x => x.RecipteDetailId);
                    table.ForeignKey(
                        name: "fk_ingredient",
                        column: x => x.IngredientId,
                        principalTable: "Ingredient",
                        principalColumn: "IngredientId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_recipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipe",
                        principalColumn: "RecipeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "AppUserId", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[,]
                {
                    { 1, "Belma", "Nukic", "JEFVxkJOeCd2ogmegwtWx+ll3Zs=", "I9RlltY0zRVbFv3/0kT7rw==", "belma" },
                    { 2, "Ema", "Bojcic", "Cfqcj9ysZmaAxARUowPltYXl09s=", "I9RlltY0zRVbFv3/0kT7rw==", "ema" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 12, "testpaging2" },
                    { 11, "testpaging1" },
                    { 9, "Soups" },
                    { 8, "Salads" },
                    { 7, "Seafood" },
                    { 10, "Breakfast" },
                    { 5, "Gluten-free" },
                    { 4, "Burgers" },
                    { 3, "Pizzas" },
                    { 2, "Waffles" },
                    { 1, "Pancakes" },
                    { 6, "Pasta" }
                });

            migrationBuilder.InsertData(
                table: "Ingredient",
                columns: new[] { "IngredientId", "Name", "Price", "Quantity", "UnitMeasure" },
                values: new object[,]
                {
                    { 9, "GreekYogurt", 2m, 2, "l" },
                    { 1, "Flour", 30m, 20, "kg" },
                    { 2, "Eggs", 10m, 20, "kom" },
                    { 3, "Milk", 10m, 8, "l" },
                    { 4, "Chicken", 50m, 5, "kg" },
                    { 5, "Beef", 45m, 3, "kg" },
                    { 6, "Salt", 5m, 5, "kg" },
                    { 7, "Vegeta", 5m, 500, "g" },
                    { 8, "Cheese", 20m, 2, "kg" },
                    { 10, "Butter", 20m, 5, "kg" }
                });

            migrationBuilder.InsertData(
                table: "Recipe",
                columns: new[] { "RecipeId", "CategoryId", "Description", "RecipeName", "TotalPrice" },
                values: new object[,]
                {
                    { 3, 1, "This is a demo3", "Ferero", 10m },
                    { 4, 1, "This is a demo4", "Protein pancake", 14m },
                    { 1, 3, "This is a demo.", "Vegetarina", 15m },
                    { 2, 3, "This is a demo part2. ", "Fungi", 19m }
                });

            migrationBuilder.InsertData(
                table: "RecipeDetail",
                columns: new[] { "RecipteDetailId", "Amount", "IngredientId", "Price", "RecipeId", "UnitMeasure" },
                values: new object[,]
                {
                    { 7, 4, 1, 2m, 3, "ml" },
                    { 8, 4, 1, 4m, 3, "ml" },
                    { 9, 2, 4, 2m, 3, "l" },
                    { 10, 3, 1, 3m, 4, "ml" },
                    { 11, 3, 3, 2m, 4, "ml" },
                    { 12, 7, 4, 4m, 4, "ml" },
                    { 1, 3, 1, 5m, 1, "g" },
                    { 2, 2, 2, 2m, 1, "l" },
                    { 3, 2, 3, 3m, 1, "ml" },
                    { 4, 3, 1, 3m, 2, "g" },
                    { 5, 3, 1, 3m, 2, "g" },
                    { 6, 4, 5, 7m, 2, "ml" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeDetail_IngredientId",
                table: "RecipeDetail",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeDetail_RecipeId",
                table: "RecipeDetail",
                column: "RecipeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUser");

            migrationBuilder.DropTable(
                name: "RecipeDetail");

            migrationBuilder.DropTable(
                name: "Ingredient");

            migrationBuilder.DropTable(
                name: "Recipe");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
