using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class tryingtoseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 46, "Sweden" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 47, "Norway" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[] { 358, "Finland" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 46, "Göteborg" },
                    { 2, 46, "Stockholm" },
                    { 3, 46, "Malmö" },
                    { 4, 47, "Oslo" },
                    { 5, 358, "Helsinki" }
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "SSN", "CityId", "Name", "PhoneNr" },
                values: new object[,]
                {
                    { "19890209-1234", 1, "Albin de Val", "0721222324" },
                    { "19700707-4321", 2, "Håkan Svensson", "031555666777" },
                    { "19801010-4125", 3, "Anders Andersson", "01234567" },
                    { "20000909-0909", 4, "Max Verstappen", "528582685" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19700707-4321");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19801010-4125");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19890209-1234");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "20000909-0909");

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 47);
        }
    }
}
