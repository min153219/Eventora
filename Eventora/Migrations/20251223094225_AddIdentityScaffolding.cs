using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Eventora.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentityScaffolding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6f3fe36-da58-4b93-b62d-8b95aa780972", new DateTime(2025, 12, 23, 17, 42, 25, 17, DateTimeKind.Local).AddTicks(5625), new DateTime(2025, 12, 23, 17, 42, 25, 17, DateTimeKind.Local).AddTicks(5643), "AQAAAAIAAYagAAAAECz+nsa19s6A55dScYSYwB3jAsVdWyILzOGVwNA6EujTsJFOHqLWpJSo21MBaEUbxg==", "04c00659-731b-4a8c-a14c-6bd22125ba8a" });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 17, 42, 24, 975, DateTimeKind.Local).AddTicks(9733), new DateTime(2025, 12, 23, 17, 42, 24, 975, DateTimeKind.Local).AddTicks(9748) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 17, 42, 24, 975, DateTimeKind.Local).AddTicks(9749), new DateTime(2025, 12, 23, 17, 42, 24, 975, DateTimeKind.Local).AddTicks(9750) });

            migrationBuilder.UpdateData(
                table: "EventTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 23, 17, 42, 24, 975, DateTimeKind.Local).AddTicks(9751), new DateTime(2025, 12, 23, 17, 42, 24, 975, DateTimeKind.Local).AddTicks(9751) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "DateCreated", "DateUpdated", "PasswordHash", "SecurityStamp" },
                values: new object[] { "894ba2a3-0934-4c03-98da-874694f2e6fb", new DateTime(2025, 12, 23, 15, 26, 34, 849, DateTimeKind.Local).AddTicks(967), new DateTime(2025, 12, 23, 15, 26, 34, 849, DateTimeKind.Local).AddTicks(1030), "AQAAAAIAAYagAAAAELo41QQnzdEHebtTGu+F4wjahc1F7j1CLjdA6HYC6pSv1VSxzNYl+0q+X29ePhFOZQ==", "4dfe6e8d-d0e9-4b97-b934-888b13d58657" });

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
        }
    }
}
