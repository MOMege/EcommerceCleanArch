using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ecommerce.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedindimage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 10, 2, 19, 28, 20, 933, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 10, 2, 19, 28, 20, 933, DateTimeKind.Local).AddTicks(647));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 10, 2, 19, 28, 20, 933, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 10, 2, 19, 28, 20, 933, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 10, 2, 19, 28, 20, 933, DateTimeKind.Local).AddTicks(661));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 10, 2, 19, 28, 20, 933, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 1,
                column: "DateOfExpired",
                value: new DateTime(2024, 10, 2, 16, 28, 20, 933, DateTimeKind.Utc).AddTicks(762));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 2,
                column: "DateOfExpired",
                value: new DateTime(2024, 10, 2, 16, 28, 20, 933, DateTimeKind.Utc).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 3,
                column: "DateOfExpired",
                value: new DateTime(2024, 10, 2, 16, 28, 20, 933, DateTimeKind.Utc).AddTicks(774));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 4,
                column: "DateOfExpired",
                value: new DateTime(2024, 10, 2, 16, 28, 20, 933, DateTimeKind.Utc).AddTicks(777));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 5,
                column: "DateOfExpired",
                value: new DateTime(2024, 10, 2, 16, 28, 20, 933, DateTimeKind.Utc).AddTicks(780));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 9, 30, 22, 28, 24, 761, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 9, 30, 22, 28, 24, 761, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 9, 30, 22, 28, 24, 761, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 9, 30, 22, 28, 24, 761, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 9, 30, 22, 28, 24, 761, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 9, 30, 22, 28, 24, 761, DateTimeKind.Local).AddTicks(2350));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 1,
                column: "DateOfExpired",
                value: new DateTime(2024, 9, 30, 19, 28, 24, 761, DateTimeKind.Utc).AddTicks(2386));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 2,
                column: "DateOfExpired",
                value: new DateTime(2024, 9, 30, 19, 28, 24, 761, DateTimeKind.Utc).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 3,
                column: "DateOfExpired",
                value: new DateTime(2024, 9, 30, 19, 28, 24, 761, DateTimeKind.Utc).AddTicks(2391));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 4,
                column: "DateOfExpired",
                value: new DateTime(2024, 9, 30, 19, 28, 24, 761, DateTimeKind.Utc).AddTicks(2392));

            migrationBuilder.UpdateData(
                table: "Visa",
                keyColumn: "VisaId",
                keyValue: 5,
                column: "DateOfExpired",
                value: new DateTime(2024, 9, 30, 19, 28, 24, 761, DateTimeKind.Utc).AddTicks(2393));
        }
    }
}
