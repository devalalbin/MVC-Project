using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class Seededuserroll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "00000000-0000-0000-0000-000000000000");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9214e530-c54b-4c38-b979-37851469075f", "2204168f-5dee-42c2-84e5-1ddf2fb949b0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2204168f-5dee-42c2-84e5-1ddf2fb949b0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9214e530-c54b-4c38-b979-37851469075f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45ea8af2-a11c-4e67-b7a6-c36c49f83386", "b0e1edc8-1d39-44a8-8b54-0fd91315d159", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "198f63b1-3ca8-4c2f-a9fd-9d63cd925a37", "d32454da-434b-41f3-a6ed-8b84ebc8bade", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BirthDate", "FirstName", "LastName" },
                values: new object[] { "95ef11db-5123-482d-9449-9005008f04ea", 0, "b339b023-2614-4e5a-880f-f5d6e2e19c87", "ApplicationUser", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEBUHPMXQV6Ws6OWvPy4wP7xbjrkVOpyhWqzjX8lg6K/JUb04d/qdN9V7EXFvtqcDmA==", null, false, "0fa57c4b-f1f5-4cda-9b9e-9444ea30e9be", false, "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Adminsson" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "95ef11db-5123-482d-9449-9005008f04ea", "45ea8af2-a11c-4e67-b7a6-c36c49f83386" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "198f63b1-3ca8-4c2f-a9fd-9d63cd925a37");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "95ef11db-5123-482d-9449-9005008f04ea", "45ea8af2-a11c-4e67-b7a6-c36c49f83386" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45ea8af2-a11c-4e67-b7a6-c36c49f83386");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "95ef11db-5123-482d-9449-9005008f04ea");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2204168f-5dee-42c2-84e5-1ddf2fb949b0", "a6f4f2aa-a1c9-4085-8971-383276d1f82c", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "00000000-0000-0000-0000-000000000000", "4b85167f-a5a0-41dc-9325-7a273a7e775b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BirthDate", "FirstName", "LastName" },
                values: new object[] { "9214e530-c54b-4c38-b979-37851469075f", 0, "8ebff298-93d9-4426-b561-0362458018d7", "ApplicationUser", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEPxXIHZ95C+RRx0T38oZngWlBXj8kI3ccQ4XS7XysbIFJ7rwnHKMkOu/t3JllFzMfw==", null, false, "cdcaaf5c-3866-49d3-a3e6-3b9d507149b2", false, "Admin", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Adminsson" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "9214e530-c54b-4c38-b979-37851469075f", "2204168f-5dee-42c2-84e5-1ddf2fb949b0" });
        }
    }
}
