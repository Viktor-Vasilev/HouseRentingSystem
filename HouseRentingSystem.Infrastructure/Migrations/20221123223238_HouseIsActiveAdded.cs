using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class HouseIsActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Houses",
                type: "bit",
                nullable: false,
                defaultValue: false);

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "0cd844e5-1c23-4ff7-8d80-1fc48eed8b01", "AQAAAAEAACcQAAAAEFdp2UMHAmN6GVRGJUKAnT0gql4nwcDlZcWTYyeV2yI8MYu7xVXd8AkVM0bGc/Bnlg==", "7f7d3643-c514-4de8-a447-3f28862ba3f7" });

            //migrationBuilder.UpdateData(
            //    table: "AspNetUsers",
            //    keyColumn: "Id",
            //    keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
            //    columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
            //    values: new object[] { "81e80566-4212-4382-bf5f-d9e103b1f3fb", "AQAAAAEAACcQAAAAEOvgcmcBqFyWpcC77NYi8YciPuSw5LBVUAI8ZheGJqU94uWpGb/keGjgwfReuKG5gQ==", "7fdbd23c-b1c5-40a7-84ac-fabf5427b97e" });

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsActive",
                value: true);

            migrationBuilder.UpdateData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsActive",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Houses");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27df7603-04a8-4139-bdc2-3be4da7712ea", "AQAAAAEAACcQAAAAEP/uNE8CDPaT+3o/Az4ZuNTS7y5nm8Kv/7oYfp9j7JxVk6vEBZtziinMUF4JcGd7yw==", "1bdf2118-5fee-44ed-b045-3b1eb8016e3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db5aeee2-0b99-4275-b066-ec14fdd3a5f3", "AQAAAAEAACcQAAAAEGFspoq8KBvdyflARj6hYJBwr2kedGen7xt0P9PNEX3Sxv7RQrY6qA+IWDwYuzfo8g==", "884d1124-ad7c-4e4e-8fd3-3e4aa60c8a29" });
        }
    }
}
