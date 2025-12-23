using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Eventora.Migrations
{
    /// <inheritdoc />
    public partial class SeedRolesAndAdminUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", null, "Administrator", "ADMINISTRATOR" },
                    { "2", null, "Customer", "CUSTOMER" },
                    { "3", null, "Organizer", "ORGANIZER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedBy", "DateCreated", "DateUpdated", "Email", "EmailConfirmed", "FullName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNo", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UpdatedBy", "UserName" },
                values: new object[] { "1", 0, "894ba2a3-0934-4c03-98da-874694f2e6fb", "System", new DateTime(2025, 12, 23, 15, 26, 34, 849, DateTimeKind.Local).AddTicks(967), new DateTime(2025, 12, 23, 15, 26, 34, 849, DateTimeKind.Local).AddTicks(1030), "admin@eventora.com", true, "System Administrator", false, null, "ADMIN@EVENTORA.COM", "ADMIN@EVENTORA.COM", "AQAAAAIAAYagAAAAELo41QQnzdEHebtTGu+F4wjahc1F7j1CLjdA6HYC6pSv1VSxzNYl+0q+X29ePhFOZQ==", "+65 1234 5678", null, false, "4dfe6e8d-d0e9-4b97-b934-888b13d58657", false, "System", "admin@eventora.com" });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 15, 26, 34, 798, DateTimeKind.Local).AddTicks(977), new DateTime(2025, 12, 23, 15, 26, 34, 798, DateTimeKind.Local).AddTicks(990) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 15, 26, 34, 798, DateTimeKind.Local).AddTicks(992), new DateTime(2025, 12, 23, 15, 26, 34, 798, DateTimeKind.Local).AddTicks(993) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 15, 26, 34, 798, DateTimeKind.Local).AddTicks(994), new DateTime(2025, 12, 23, 15, 26, 34, 798, DateTimeKind.Local).AddTicks(995) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 15, 10, 19, 460, DateTimeKind.Local).AddTicks(4493), new DateTime(2025, 12, 23, 15, 10, 19, 460, DateTimeKind.Local).AddTicks(4509) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 15, 10, 19, 460, DateTimeKind.Local).AddTicks(4513), new DateTime(2025, 12, 23, 15, 10, 19, 460, DateTimeKind.Local).AddTicks(4513) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 15, 10, 19, 460, DateTimeKind.Local).AddTicks(4515), new DateTime(2025, 12, 23, 15, 10, 19, 460, DateTimeKind.Local).AddTicks(4516) });
        }
    }
}
