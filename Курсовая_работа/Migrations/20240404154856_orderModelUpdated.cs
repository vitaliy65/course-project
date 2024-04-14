using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Курсовая_работа.Migrations
{
    /// <inheritdoc />
    public partial class orderModelUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_customers_customerId",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "customerId",
                table: "orders",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_customerId",
                table: "orders",
                newName: "IX_orders_CustomerId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_customers_CustomerId",
                table: "orders",
                column: "CustomerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_customers_CustomerId",
                table: "orders");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "orders",
                newName: "customerId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_CustomerId",
                table: "orders",
                newName: "IX_orders_customerId");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_customers_customerId",
                table: "orders",
                column: "customerId",
                principalTable: "customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
