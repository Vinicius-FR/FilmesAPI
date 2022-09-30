using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicionandocustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99990,
                column: "ConcurrencyStamp",
                value: "22c56049-d6d3-4009-bac3-c416c1a6a712");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "2d10019a-6147-48cc-90ae-32fa783844e7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1c6ba14-b578-47a0-b006-262ffc04a2f4", "AQAAAAEAACcQAAAAEDJJbnHQTr17jhk08GdoMzVBTMjKVZ3bmiC8v82mF0LaZdPy4EWzJIzvzarAkKG/Fg==", "b202ca14-643f-42fc-9759-723addce849c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99990,
                column: "ConcurrencyStamp",
                value: "05685372-3624-46c7-9b00-71c889319de4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6ae356c0-aa08-49b5-a9fc-fc7af8497c4f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87812604-9be8-4415-b994-31f1d06c2339", "AQAAAAEAACcQAAAAEC9L3f//XPHziDEqTgzinlfTpjtRlyUoW+oCPvGNRKz/vIhC2Ybwl73SnRfuYm0VuQ==", "cb9af324-5d3f-4591-a472-486395ac2541" });
        }
    }
}
