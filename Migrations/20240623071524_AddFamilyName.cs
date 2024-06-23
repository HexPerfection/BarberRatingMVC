using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItKariera.Migrations
{
    /// <inheritdoc />
    public partial class AddFamilyName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75d970dd-ab91-446f-847f-faed51a79fb5", "John", "Doe", "AQAAAAIAAYagAAAAEF5adYyt3CN2SqLtVDNA5dilpYH5sXQKdMp1tnO/JGMVaMVAFML/5FQ/gZ+IJv8SYw==", "41d44f75-a360-4fc5-b6a5-7ce10f1b504c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "AspNetUsers",
                newName: "Name");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02174cf0–9412–4cfe-afbf-59f706d72cf6",
                columns: new[] { "ConcurrencyStamp", "Name", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e8bb22c-a75c-40f9-b0f0-7ec0ab96e7d8", "Admin", "AQAAAAIAAYagAAAAEMpys3y/iMn4zEuNU6IGMPEd5ZpZeQI6+hnvfQLWY2cShfnRwjMFKpVlW2XbCnJu9A==", "443d3586-7d88-4ee7-aa7a-28330206a875" });
        }
    }
}
