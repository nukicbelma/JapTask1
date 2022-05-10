using Microsoft.EntityFrameworkCore.Migrations;

namespace API.Migrations
{
    public partial class m3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { "Belma", "Nukic", "hUbtvs3Ht81qIsXCCTtWOMZIy+M=", "AttaYbzFcm+DYsZM1Fkqfg==", "belma" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { "Ema", "Bojcic", "U4n07RpuUvp1Wxnr9j8SwmVIg7g=", "AttaYbzFcm+DYsZM1Fkqfg==", "ema" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { "Hanna", "Tiro", "wnCB/frLUlyfIotXkjl4u2UDPLM=", "Co0MzRMbuF1yuJbljtYERA==", "hanna" });

            migrationBuilder.UpdateData(
                table: "AppUser",
                keyColumn: "AppUserId",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { "Belma", "Nukic", "mfS39Pa/aE2p5ZtXjTn7fmdHqD8=", "t/pWv2wL1brH7KgubE3dxg==", "belma" });
        }
    }
}
