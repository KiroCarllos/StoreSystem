using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageAppSystem.Migrations
{
    /// <inheritdoc />
    public partial class removeWarehouseFromProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_warehouses_WarehouseId",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "products",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_products_warehouses_WarehouseId",
                table: "products",
                column: "WarehouseId",
                principalTable: "warehouses",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_warehouses_WarehouseId",
                table: "products");

            migrationBuilder.AlterColumn<int>(
                name: "WarehouseId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_products_warehouses_WarehouseId",
                table: "products",
                column: "WarehouseId",
                principalTable: "warehouses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
