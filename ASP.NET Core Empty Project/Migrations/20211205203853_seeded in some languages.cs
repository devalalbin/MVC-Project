using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class seededinsomelanguages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Swdedish" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "German" });

            migrationBuilder.InsertData(
                table: "Languages",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "English" });

            migrationBuilder.InsertData(
                table: "PersonLanguage",
                columns: new[] { "PersonId", "LanguageId" },
                values: new object[,]
                {
                    { "19890209-1234", 1 },
                    { "20000909-0909", 1 },
                    { "19890209-1234", 2 },
                    { "19890209-1234", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonLanguage",
                keyColumns: new[] { "PersonId", "LanguageId" },
                keyValues: new object[] { "19890209-1234", 1 });

            migrationBuilder.DeleteData(
                table: "PersonLanguage",
                keyColumns: new[] { "PersonId", "LanguageId" },
                keyValues: new object[] { "19890209-1234", 2 });

            migrationBuilder.DeleteData(
                table: "PersonLanguage",
                keyColumns: new[] { "PersonId", "LanguageId" },
                keyValues: new object[] { "19890209-1234", 3 });

            migrationBuilder.DeleteData(
                table: "PersonLanguage",
                keyColumns: new[] { "PersonId", "LanguageId" },
                keyValues: new object[] { "20000909-0909", 1 });

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
