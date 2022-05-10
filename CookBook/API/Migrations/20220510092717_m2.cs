using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class m2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "AppUserId", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, "Hanna", "Tiro", "wnCB/frLUlyfIotXkjl4u2UDPLM=", "Co0MzRMbuF1yuJbljtYERA==", "hanna" });

            migrationBuilder.InsertData(
                table: "AppUser",
                columns: new[] { "AppUserId", "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, "Belma", "Nukic", "mfS39Pa/aE2p5ZtXjTn7fmdHqD8=", "t/pWv2wL1brH7KgubE3dxg==", "belma" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 2);
        }
    }
}
