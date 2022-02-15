using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class seededmorepeople : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "832f2200-9282-43ea-a9ea-508bdb387570");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "aa2e6582-387f-4001-9afb-86b59ecf7672", "1be1ea04-a745-445d-9471-3f3ab3873133" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1be1ea04-a745-445d-9471-3f3ab3873133");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aa2e6582-387f-4001-9afb-86b59ecf7672");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "342253c5-b27d-429e-a14e-6a20e7e72a8b", "3878a0b9-2f51-48ea-8c5d-1a7ac7524786", "Admin", "ADMIN" },
                    { "6359993c-3883-4055-a1a5-72fc15a90892", "a1038d85-b570-474a-8a9f-8dfaf27d4268", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BirthDate", "FirstName", "LastName" },
                values: new object[] { "cdd4101f-2abc-46e5-b025-76c21713c5f5", 0, "c074402b-dee4-4e68-b87a-536410411e77", "ApplicationUser", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEOLqNnbgeFywD/9wVzWGWtfWdXx33l5Kp67gjUpc6/nG9/dqC5DVu8SfWwofwsb/pw==", null, false, "8c0938c9-ab68-4531-8b63-e43b36ebbb1d", false, "admin@admin.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Adminsson" });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "SSN", "CityId", "Name", "PhoneNr" },
                values: new object[,]
                {
                    { "19894444-1234", 1, "Albin de Val", "21461284814" },
                    { "19895555-1234", 2, "Lars Larsson", "41824361284" },
                    { "19896666-1243", 3, "Hasse Hasseson", "12482164124" },
                    { "19890777-1234", 4, "Eidjur Hömlig", "12434141234" },
                    { "19890888-1555", 1, "Vanlig Man", "14214322451" },
                    { "19899999-1322", 2, "Hemlig Agent", "41241245523" },
                    { "19890100-1234", 3, "Nibla de Val", "41231235123" },
                    { "19890323-1555", 4, "Seedad Kille", "12312455123" },
                    { "19890212-1244", 1, "Nisse Nisseson", "31232415125" },
                    { "55555555-1234", 1, "Ral Ralfsson", "12412412412" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "cdd4101f-2abc-46e5-b025-76c21713c5f5", "342253c5-b27d-429e-a14e-6a20e7e72a8b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6359993c-3883-4055-a1a5-72fc15a90892");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "cdd4101f-2abc-46e5-b025-76c21713c5f5", "342253c5-b27d-429e-a14e-6a20e7e72a8b" });

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19890100-1234");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19890212-1244");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19890323-1555");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19890777-1234");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19890888-1555");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19894444-1234");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19895555-1234");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19896666-1243");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "19899999-1322");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "SSN",
                keyValue: "55555555-1234");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "342253c5-b27d-429e-a14e-6a20e7e72a8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cdd4101f-2abc-46e5-b025-76c21713c5f5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1be1ea04-a745-445d-9471-3f3ab3873133", "595ab74b-8b7f-401f-b4f2-465098f9d7eb", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "832f2200-9282-43ea-a9ea-508bdb387570", "e58c2b79-e749-4363-8bba-a6eb4b877750", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BirthDate", "FirstName", "LastName" },
                values: new object[] { "aa2e6582-387f-4001-9afb-86b59ecf7672", 0, "21e4383c-c424-479d-8dfb-1eb036514418", "ApplicationUser", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEF2Z7/HtIagosyeIQp+LIHYRkwDjsWcl2Lj4iM0xUm4XwNrxhh8dM7m52pe4ggaSWA==", null, false, "4323c142-6735-4948-90a1-fa8b8b4b01ed", false, "admin@admin.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Adminsson" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "aa2e6582-387f-4001-9afb-86b59ecf7672", "1be1ea04-a745-445d-9471-3f3ab3873133" });
        }
    }
}
