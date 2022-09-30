using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class Adicionandocustomidentityuser2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99990,
                column: "ConcurrencyStamp",
                value: "d4fddc46-d347-49ec-8e94-929a0b894b13");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "4c76b207-b006-4ee5-ac63-627218ba4967");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54775cf2-9dff-41a2-b861-b62174319e91", "AQAAAAEAACcQAAAAEBeqMuvfIiluIMCKVe28h7SYdOqOtvw7wRVjBlw5nhEEtDo8XhwNzrHg7N5rTxqhQQ==", "d4be2e2f-1f4a-456f-ac56-8ae9ff013f1b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
