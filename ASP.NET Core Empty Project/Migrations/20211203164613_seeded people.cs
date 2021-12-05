using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class seededpeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    SSN = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(nullable: false),
                    PhoneNr = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.SSN);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    SSN = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.SSN);
                });
        }
    }
}
