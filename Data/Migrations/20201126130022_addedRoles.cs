using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTrashCollector.Data.Migrations
{
    public partial class addedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a59cb07b-1d27-469e-87a0-a936593033bd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3f6e493c-beee-4067-8f12-f1359e3d0af2", "cb45e3b9-3127-4f0a-8c34-86b883f7e297", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f9ede829-d28a-447e-8c38-4213edac30d2", "30fc826c-578f-4c4d-aa6d-2fb398ae38c7", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72a351fc-0a0b-439c-a15d-a746103b2b51", "6ddcac06-6a42-4de4-96f0-e5e4909de3e8", "Employee", "EMPLOYEE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3f6e493c-beee-4067-8f12-f1359e3d0af2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72a351fc-0a0b-439c-a15d-a746103b2b51");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f9ede829-d28a-447e-8c38-4213edac30d2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a59cb07b-1d27-469e-87a0-a936593033bd", "bce36a18-b2e9-4199-8df8-a872989e7707", "Admin", "ADMIN" });
        }
    }
}
