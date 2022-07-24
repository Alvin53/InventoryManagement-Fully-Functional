using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagement.Web.Migrations
{
    public partial class ResetMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "502aA320-30b8-4996-8A99-bf4d3274af34",
                column: "ConcurrencyStamp",
                value: "4a98e1bd-a537-40ef-8be1-522aa8e73007");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "605ae320-30b8-4996-8c99-bf4d3274cf32",
                column: "ConcurrencyStamp",
                value: "3b8d239e-01d1-4c6d-866c-a8bb56d54299");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b06a079-d2c3-4b00-bb14-148b795cc2f9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b2e4930-b112-4845-be72-a3ba501e4bfa", "AQAAAAEAACcQAAAAEC2NujpX0Vjpikv7Bknz+yF7FuITppIB5QNxQRU/+3Yd31dstH/7UTKOJ95MpPidPg==", "b2d59579-5bf7-4448-b034-7111a30f1dfa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "641441d9-073b-45d3-81d5-7edbcb0faff7",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8352e5f6-4c40-4283-9d32-9930de26b79c", "AQAAAAEAACcQAAAAEFTF/lbUN/dzG4gSA9H3qnQ9Ltr4g5itjjNbVGwUZ8p4hBFYQjlGJIKk76WPNU97zA==", "6539d9fc-a5f0-4f0f-b214-fb9036ed9a53" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
