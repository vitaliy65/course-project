using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Курсовая_работа.Migrations
{
    /// <inheritdoc />
    public partial class ProductUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_products_productId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_products_restaurants_RestaurantId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "products",
                newName: "ProductId");

            migrationBuilder.RenameColumn(
                name: "productId",
                table: "orders",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_productId",
                table: "orders",
                newName: "IX_orders_ProductId");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_orders_products_ProductId",
                table: "orders",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_restaurants_RestaurantId",
                table: "products",
                column: "RestaurantId",
                principalTable: "restaurants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_orders_products_ProductId",
                table: "orders");

            migrationBuilder.DropForeignKey(
                name: "FK_products_restaurants_RestaurantId",
                table: "products");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "products",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "orders",
                newName: "productId");

            migrationBuilder.RenameIndex(
                name: "IX_orders_ProductId",
                table: "orders",
                newName: "IX_orders_productId");

            migrationBuilder.AlterColumn<int>(
                name: "RestaurantId",
                table: "products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_orders_products_productId",
                table: "orders",
                column: "productId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_restaurants_RestaurantId",
                table: "products",
                column: "RestaurantId",
                principalTable: "restaurants",
                principalColumn: "Id");
        }
    }
}
