using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Курсовая_работа.Migrations
{
    /// <inheritdoc />
    public partial class addFirstLastName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstLastName",
                table: "customers",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstLastName",
                table: "customers");
        }
    }
}
