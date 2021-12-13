using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class seededadminagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a8ad1f87-afba-4ca1-be00-ee745ba10db4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6e072a94-da93-40b8-a533-82af30f0f402", "c94af821-bf66-473d-9bbc-fde3b011f57a" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c94af821-bf66-473d-9bbc-fde3b011f57a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6e072a94-da93-40b8-a533-82af30f0f402");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c94af821-bf66-473d-9bbc-fde3b011f57a", "9c4b3cc3-f392-4e12-82e8-5421e1863f92", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a8ad1f87-afba-4ca1-be00-ee745ba10db4", "ab755a59-565d-449c-a648-64f7ad71aba6", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "BirthDate", "FirstName", "LastName" },
                values: new object[] { "6e072a94-da93-40b8-a533-82af30f0f402", 0, "92a1e542-3a54-4554-a018-b9671232347c", "ApplicationUser", "admin@admin.com", false, false, null, "ADMIN@ADMIN.COM", "ADMIN", "AQAAAAEAACcQAAAAEO65IkeuYQfVBLX1NMB1kcJCfnEwSqUWhdQd1lgQZLJzNumUDa9cfYdsao9RDjow1A==", null, false, "6c3afd9d-cecf-4c4f-8175-5fabc363a2cd", false, "admin@admin.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", "Adminsson" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "6e072a94-da93-40b8-a533-82af30f0f402", "c94af821-bf66-473d-9bbc-fde3b011f57a" });
        }
    }
}
