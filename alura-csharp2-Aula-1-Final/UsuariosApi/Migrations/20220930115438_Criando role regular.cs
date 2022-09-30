using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6ae356c0-aa08-49b5-a9fc-fc7af8497c4f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99990, "05685372-3624-46c7-9b00-71c889319de4", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87812604-9be8-4415-b994-31f1d06c2339", "AQAAAAEAACcQAAAAEC9L3f//XPHziDEqTgzinlfTpjtRlyUoW+oCPvGNRKz/vIhC2Ybwl73SnRfuYm0VuQ==", "cb9af324-5d3f-4591-a472-486395ac2541" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99990);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "64da0a73-3580-48fc-a906-208163c9c02a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5fbcbba-d7ae-4c91-bbdb-35728d2fdcd8", "AQAAAAEAACcQAAAAEDXMwviuVFqiZrfgijlEg6BwLwenfnF0TolszjJhGbovELfR30n3/Mr1J66WmsFVcA==", "3db4cbe9-7e2f-4b3d-82ee-4f3a4184907b" });
        }
    }
}
