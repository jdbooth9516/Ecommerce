using Microsoft.EntityFrameworkCore.Migrations;

namespace eCommerceStarterCode.Migrations
{
    public partial class user : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bac11c31-800e-4b31-823f-86b66bc29eb4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f353035d-5fa5-4856-89ee-29d001460129");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "7599eb16-93f5-4d09-80d7-fc2dbf268f75", "265b530e-83bb-4478-a700-08b72d0c234d", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "45ba8404-8a32-43c1-abd5-0e242dbbefb3", "7c391c2a-4bd2-45e1-9650-2cf9efeb7f6f", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "45ba8404-8a32-43c1-abd5-0e242dbbefb3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7599eb16-93f5-4d09-80d7-fc2dbf268f75");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f353035d-5fa5-4856-89ee-29d001460129", "16be765c-1dbc-4635-a284-7f32f4e6100b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bac11c31-800e-4b31-823f-86b66bc29eb4", "cabbafbf-cb0a-458b-8265-193f9c881051", "Admin", "ADMIN" });
        }
    }
}
