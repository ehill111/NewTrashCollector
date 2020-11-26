using Microsoft.EntityFrameworkCore.Migrations;

namespace NewTrashCollector.Data.Migrations
{
    public partial class updatedEmployeeModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6e2ddb2-1de8-4101-9aa3-a4b9cdfcb1ed");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a59cb07b-1d27-469e-87a0-a936593033bd", "bce36a18-b2e9-4199-8df8-a872989e7707", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a59cb07b-1d27-469e-87a0-a936593033bd");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6e2ddb2-1de8-4101-9aa3-a4b9cdfcb1ed", "5be425d0-4588-4520-a343-fd4073d0220f", "Admin", "ADMIN" });
        }
    }
}
