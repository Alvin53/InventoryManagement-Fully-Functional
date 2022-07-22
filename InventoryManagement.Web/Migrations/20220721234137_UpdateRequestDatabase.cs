using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Web.Migrations
{
    public partial class UpdateRequestDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequstComments",
                table: "ItemRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "ProductQuantity",
                table: "ItemRequests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "502aA320-30b8-4996-8A99-bf4d3274af34",
                column: "ConcurrencyStamp",
                value: "84354d42-63ed-4cc5-a8db-520e4695fca1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "605ae320-30b8-4996-8c99-bf4d3274cf32",
                column: "ConcurrencyStamp",
                value: "6e4b9a41-9d03-4b98-9932-04a9dfa72347");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b06a079-d2c3-4b00-bb14-148b795cc2f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "30edefb7-b9dc-4ca3-b85a-e09e4ce65aec", "AQAAAAEAACcQAAAAEFrIWI50yDkk+N6DJQbD2FwIyr9e+aHHikmzGM0CVSk01bLP3VQv3ZEkgJcYSA5ioA==", "bbb39aa5-7abb-4d66-9453-0dfe8ce15910" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "641441d9-073b-45d3-81d5-7edbcb0faff7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16def305-a03a-4ddb-aec5-b29786a5b13b", "AQAAAAEAACcQAAAAELnEXJ21Z67ZdPInkIdgZE/tCgPP2RkzrY9NbdhkaThOfzNT8f64qmKC7VTGQRkmUA==", "e1bd4103-7d75-404f-8512-a7bf7099ce12" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductQuantity",
                table: "ItemRequests");

            migrationBuilder.AlterColumn<string>(
                name: "RequstComments",
                table: "ItemRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "502aA320-30b8-4996-8A99-bf4d3274af34",
                column: "ConcurrencyStamp",
                value: "2231fe61-aedf-4edc-afb8-372778635cf3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "605ae320-30b8-4996-8c99-bf4d3274cf32",
                column: "ConcurrencyStamp",
                value: "6bf3e7ed-6c0f-4ee6-b7a2-dbf07fdcc611");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b06a079-d2c3-4b00-bb14-148b795cc2f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "902be40b-218c-4a73-b79b-f58bdc762a7f", "AQAAAAEAACcQAAAAENtaqHSuCia+lq5Mn+OEx9Em6EmnZD+GIjIk59qwdyQH5YKf9KoNolzk/bucTbVpIQ==", "55eec577-4a5e-4be2-88db-9a792e5d1a01" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "641441d9-073b-45d3-81d5-7edbcb0faff7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2fc1abd2-5557-4bb6-afd9-c4fa24c61314", "AQAAAAEAACcQAAAAEFSd6CH6MAPNOsnXzTjKoFlE+jifdTV0S5t4g66cqLdMmKQdwClt4G1ZPjf4AptFmQ==", "ee9b45de-4213-4cf0-82d9-3d5a87ba34ee" });
        }
    }
}
