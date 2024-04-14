using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Курсовая_работа.Migrations
{
    /// <inheritdoc />
    public partial class addedCustomerCoordinates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Latitude",
                table: "customers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "Longitude",
                table: "customers",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Latitude",
                table: "customers");

            migrationBuilder.DropColumn(
                name: "Longitude",
                table: "customers");
        }
    }
}
