using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StorageAppSystem.Migrations
{
    /// <inheritdoc />
    public partial class initalCreateDatabasesTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "warehouses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ManagerName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_warehouses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    AddedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "supplyOrders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    OrderNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplyOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_supplyOrders_suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_supplyOrders_warehouses_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "warehouses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "productUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_productUnits_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "supplyOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplyOrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplyOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_supplyOrderDetails_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_supplyOrderDetails_supplyOrders_SupplyOrderId",
                        column: x => x.SupplyOrderId,
                        principalTable: "supplyOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_WarehouseId",
                table: "products",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_productUnits_ProductId",
                table: "productUnits",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrderDetails_ProductId",
                table: "supplyOrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrderDetails_SupplyOrderId",
                table: "supplyOrderDetails",
                column: "SupplyOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrders_SupplierId",
                table: "supplyOrders",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_supplyOrders_WarehouseId",
                table: "supplyOrders",
                column: "WarehouseId");


            // Insert data into warehouses
            migrationBuilder.Sql("INSERT INTO warehouses (Name, Address, ManagerName) VALUES ('Warehouse 1', 'Address 1', 'Manager Test 1')");
            migrationBuilder.Sql("INSERT INTO warehouses (Name, Address, ManagerName) VALUES ('Warehouse 2', 'Address 2', 'Manager Test 2')");
            migrationBuilder.Sql("INSERT INTO warehouses (Name, Address, ManagerName) VALUES ('Warehouse 3', 'Address 3', 'Manager Test 3')");

            // Insert data into clients
            migrationBuilder.Sql("INSERT INTO clients (Name, Fax, Phone, Email, Website) VALUES ('Client 1', '123456789', '0123456789', 'client1@example.com', 'www.client1.com')");
            migrationBuilder.Sql("INSERT INTO clients (Name, Fax, Phone, Email, Website) VALUES ('Client 2', '987654321', '0987654321', 'client2@example.com', 'www.client2.com')");
            migrationBuilder.Sql("INSERT INTO clients (Name, Fax, Phone, Email, Website) VALUES ('Client 3', '567891234', '0567891234', 'client3@example.com', 'www.client3.com')");

            // Insert data into suppliers
            migrationBuilder.Sql("INSERT INTO suppliers (Name, Fax, Phone, Email, Website) VALUES ('Supplier 1', '111111111', '0111111111', 'supplier1@example.com', 'www.supplier1.com')");
            migrationBuilder.Sql("INSERT INTO suppliers (Name, Fax, Phone, Email, Website) VALUES ('Supplier 2', '222222222', '0222222222', 'supplier2@example.com', 'www.supplier2.com')");
            migrationBuilder.Sql("INSERT INTO suppliers (Name, Fax, Phone, Email, Website) VALUES ('Supplier 3', '333333333', '0333333333', 'supplier3@example.com', 'www.supplier3.com')");

            // Insert data into products
            migrationBuilder.Sql("INSERT INTO products (Name, Barcode, WarehouseId, AddedOn) VALUES ('Product A', '1234567890', 1, GETDATE())");
            migrationBuilder.Sql("INSERT INTO products (Name, Barcode, WarehouseId, AddedOn) VALUES ('Product B', '0987654321', 2, GETDATE())");
            migrationBuilder.Sql("INSERT INTO products (Name, Barcode, WarehouseId, AddedOn) VALUES ('Product C', '5678901234', 3, GETDATE())");

            // Insert data into supplyOrders
            migrationBuilder.Sql("INSERT INTO supplyOrders (WarehouseId, SupplierId, OrderNumber, OrderDate) VALUES (1, 1, 'ORD001', GETDATE())");
            migrationBuilder.Sql("INSERT INTO supplyOrders (WarehouseId, SupplierId, OrderNumber, OrderDate) VALUES (2, 2, 'ORD002', GETDATE())");
            migrationBuilder.Sql("INSERT INTO supplyOrders (WarehouseId, SupplierId, OrderNumber, OrderDate) VALUES (3, 3, 'ORD003', GETDATE())");

            // Insert data into productUnits
            migrationBuilder.Sql("INSERT INTO productUnits (UnitName, ProductId) VALUES ('Box', 1)");
            migrationBuilder.Sql("INSERT INTO productUnits (UnitName, ProductId) VALUES ('Pack', 2)");
            migrationBuilder.Sql("INSERT INTO productUnits (UnitName, ProductId) VALUES ('Piece', 3)");

            // Insert data into supplyOrderDetails
            migrationBuilder.Sql("INSERT INTO supplyOrderDetails (SupplyOrderId, ProductId, Quantity, ProductionDate, ExpiryDate) VALUES (1, 1, 100, GETDATE(), DATEADD(YEAR, 1, GETDATE()))");
            migrationBuilder.Sql("INSERT INTO supplyOrderDetails (SupplyOrderId, ProductId, Quantity, ProductionDate, ExpiryDate) VALUES (2, 2, 200, GETDATE(), DATEADD(YEAR, 1, GETDATE()))");
            migrationBuilder.Sql("INSERT INTO supplyOrderDetails (SupplyOrderId, ProductId, Quantity, ProductionDate, ExpiryDate) VALUES (3, 3, 300, GETDATE(), DATEADD(YEAR, 1, GETDATE()))");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clients");

            migrationBuilder.DropTable(
                name: "productUnits");

            migrationBuilder.DropTable(
                name: "supplyOrderDetails");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "supplyOrders");

            migrationBuilder.DropTable(
                name: "suppliers");

            migrationBuilder.DropTable(
                name: "warehouses");
        }
    }
}
