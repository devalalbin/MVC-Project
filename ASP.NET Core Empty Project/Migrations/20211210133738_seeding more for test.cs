using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class seedingmorefortest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "PersonLanguage",
                columns: new[] { "PersonId", "LanguageId" },
                values: new object[,]
                {
                    { "19700707-4321", 1 },
                    { "19700707-4321", 2 },
                    { "19801010-4125", 1 },
                    { "19801010-4125", 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "PersonLanguage",
                keyColumns: new[] { "PersonId", "LanguageId" },
                keyValues: new object[] { "19700707-4321", 1 });

            migrationBuilder.DeleteData(
                table: "PersonLanguage",
                keyColumns: new[] { "PersonId", "LanguageId" },
                keyValues: new object[] { "19700707-4321", 2 });

            migrationBuilder.DeleteData(
                table: "PersonLanguage",
                keyColumns: new[] { "PersonId", "LanguageId" },
                keyValues: new object[] { "19801010-4125", 1 });

            migrationBuilder.DeleteData(
                table: "PersonLanguage",
                keyColumns: new[] { "PersonId", "LanguageId" },
                keyValues: new object[] { "19801010-4125", 3 });
        }
    }
}
