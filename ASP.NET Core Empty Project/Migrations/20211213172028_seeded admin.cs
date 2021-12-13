using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NET_Core_Empty_Project.Migrations
{
    public partial class seededadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
