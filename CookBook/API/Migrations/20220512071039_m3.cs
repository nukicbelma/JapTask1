using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Recipe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "aEDpc3lY+9Jusc/gvsB7Rc3JrBA=", "xUMBanhCnM8gFy+8nqRQ3g==" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "DQG9LFazEDs70+2vsTZarkNNeVk=", "xUMBanhCnM8gFy+8nqRQ3g==" });

            migrationBuilder.CreateIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipe_Category_CategoryId",
                table: "Recipe");

            migrationBuilder.DropIndex(
                name: "IX_Recipe_CategoryId",
                table: "Recipe");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Recipe");

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "643Xot51rXTlmnjWOvoaOuYMZZo=", "2HyTUtcpq3qFpsjtDuVzLA==" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { "oo2r3buBVQdB1QybsybtkN7HXtU=", "2HyTUtcpq3qFpsjtDuVzLA==" });
        }
    }
}
