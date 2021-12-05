using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class seedingtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "12131");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "123455959");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "75757");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "SSN", "Name", "PhoneNr" },
                values: new object[,]
                {
                    { "12345595", "Albin de Val", "0721222324" },
                    { "1213141", "Håkan Svensson", "031555666777" },
                    { "7575741", "Anders Andersson", "1234567" },
                    { "444555222", "Max Verstappen", "528582685" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "1213141");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "12345595");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "444555222");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "7575741");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "SSN", "Name", "PhoneNr" },
                values: new object[] { "123455959", "Albin de Val", "0721222324" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "SSN", "Name", "PhoneNr" },
                values: new object[] { "12131", "Håkan Svensson", "031555666777" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "SSN", "Name", "PhoneNr" },
                values: new object[] { "75757", "Anders Andersson", "1234567" });
        }
    }
}
