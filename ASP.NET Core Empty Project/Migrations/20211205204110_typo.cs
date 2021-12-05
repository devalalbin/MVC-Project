using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Swedish");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Swdedish");
        }
    }
}
