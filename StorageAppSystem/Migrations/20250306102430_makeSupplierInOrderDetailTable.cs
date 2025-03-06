using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageAppSystem.Migrations
{
    /// <inheritdoc />
    public partial class makeSupplierInOrderDetailTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_supplyOrders_suppliers_SupplierId",
                table: "supplyOrders");

            migrationBuilder.DropIndex(
                name: "IX_supplyOrders_SupplierId",
                table: "supplyOrders");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "supplyOrders");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "supplyOrderDetails",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrderDetails_SupplierId",
                table: "supplyOrderDetails",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_supplyOrderDetails_suppliers_SupplierId",
                table: "supplyOrderDetails",
                column: "SupplierId",
                principalTable: "suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_supplyOrderDetails_suppliers_SupplierId",
                table: "supplyOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_supplyOrderDetails_SupplierId",
                table: "supplyOrderDetails");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "supplyOrderDetails");

            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "supplyOrders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrders_SupplierId",
                table: "supplyOrders",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_supplyOrders_suppliers_SupplierId",
                table: "supplyOrders",
                column: "SupplierId",
                principalTable: "suppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
