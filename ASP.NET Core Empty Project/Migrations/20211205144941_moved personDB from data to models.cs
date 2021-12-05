using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class movedpersonDBfromdatatomodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "SSN",
                table: "People",
                maxLength: 13,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "SSN", "Name", "PhoneNr" },
                values: new object[,]
                {
                    { "19890209-1234", "Albin de Val", "0721222324" },
                    { "19700707-4321", "Håkan Svensson", "031555666777" },
                    { "19801010-4125", "Anders Andersson", "1234567" },
                    { "20000909-0909", "Max Verstappen", "528582685" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "SSN",
                table: "People",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 13);

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
    }
}
