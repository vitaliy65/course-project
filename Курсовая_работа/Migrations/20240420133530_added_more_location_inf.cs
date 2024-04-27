using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Курсовая_работа.Migrations
{
    /// <inheritdoc />
    public partial class added_more_location_inf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "city",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "country",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "regionName",
                table: "customers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "city",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "country",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "regionName",
                table: "customers");
        }
    }
}
