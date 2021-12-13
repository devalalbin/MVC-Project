using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class checkinguserstatus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3de09564-55d0-4aa9-84e2-5a59e03ff47d");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "dd78b599-8a86-40ed-b885-8f7970eb96eb", "a182d4fd-db9b-4a2f-8f92-17789bc37650" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a182d4fd-db9b-4a2f-8f92-17789bc37650");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd78b599-8a86-40ed-b885-8f7970eb96eb");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "a182d4fd-db9b-4a2f-8f92-17789bc37650", "78c639f9-4bcd-46d9-9416-307574dc1114", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3de09564-55d0-4aa9-84e2-5a59e03ff47d", "58fc3812-fd5a-4a71-a7c2-48b709f8dfd3", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BirthDate", "FirstName", "LastName" },
                values: new object[] { "dd78b599-8a86-40ed-b885-8f7970eb96eb", 0, "9de2c05c-4ad1-4e09-ae1b-a58f407e68e6", "ApplicationUser", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAEN89agVaf1yNzwhWjNymCUVzt8hYf0IFr82n+54h/6pmMcNwQo7891KUGmO3zJ83Kw==", null, false, "d7592a01-1368-417c-8b9b-fbd69ef099fa", false, "admin@admin.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Adminsson" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "dd78b599-8a86-40ed-b885-8f7970eb96eb", "a182d4fd-db9b-4a2f-8f92-17789bc37650" });
        }
    }
}
