using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class fixedseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3af5cf7f-9566-4bad-b6aa-8bbdeab0d8ab", "d7a3d197-1ee6-4e8d-92a1-98469269fee4", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "52112bc1-0d60-422e-a9b3-eeeb934bdc94", "b729bdc7-372b-4ae8-91ed-d2261e19bc0d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BirthDate", "FirstName", "LastName" },
                values: new object[] { "244b02ad-8a26-412e-b1a1-432c57ca8532", 0, "dbdb9f8d-f50b-4823-bf20-a2a7baea749b", "ApplicationUser", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAENGSnmWf36DTJjIj21At6wZBIoDi7G8/eLvt1eWNytKcaTe0Zfp2ViYMdUAodqEavA==", null, false, "231ecdeb-9b24-4170-9161-dcb0608ad9d0", false, "admin@admin.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Adminsson" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "244b02ad-8a26-412e-b1a1-432c57ca8532", "3af5cf7f-9566-4bad-b6aa-8bbdeab0d8ab" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "52112bc1-0d60-422e-a9b3-eeeb934bdc94");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "244b02ad-8a26-412e-b1a1-432c57ca8532", "3af5cf7f-9566-4bad-b6aa-8bbdeab0d8ab" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3af5cf7f-9566-4bad-b6aa-8bbdeab0d8ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "244b02ad-8a26-412e-b1a1-432c57ca8532");

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
    }
}
