using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Almacenes",
                columns: table => new
                {
                    AlmacenId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    AlmacenName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    AlmacenDireccion = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Almacenes", x => x.AlmacenId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    categoryId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    categoryName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.categoryId);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    ProductName = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ProductDescription = table.Column<string>(type: "varchar(600)", maxLength: 600, nullable: false),
                    ProductQuantity = table.Column<int>(type: "int", nullable: false),
                    categoryId = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Category_categoryId",
                        column: x => x.categoryId,
                        principalTable: "Category",
                        principalColumn: "categoryId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Bodegas",
                columns: table => new
                {
                    BodegaId = table.Column<string>(type: "varchar(10)", maxLength: 10, nullable: false),
                    UltimaActualizacion = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CatidadParcial = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<string>(type: "varchar(10)", nullable: false),
                    AlmacenId = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bodegas", x => x.BodegaId);
                    table.ForeignKey(
                        name: "FK_Bodegas_Almacenes_AlmacenId",
                        column: x => x.AlmacenId,
                        principalTable: "Almacenes",
                        principalColumn: "AlmacenId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bodegas_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ingresosySalidas",
                columns: table => new
                {
                    IngresoId = table.Column<string>(type: "varchar(255)", nullable: false),
                    IngresoFecha = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Cantidad = table.Column<int>(type: "int", nullable: false),
                    Isinput = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    BodegaId = table.Column<string>(type: "longtext", nullable: false),
                    BodegasBodegaId = table.Column<string>(type: "varchar(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ingresosySalidas", x => x.IngresoId);
                    table.ForeignKey(
                        name: "FK_ingresosySalidas_Bodegas_BodegasBodegaId",
                        column: x => x.BodegasBodegaId,
                        principalTable: "Bodegas",
                        principalColumn: "BodegaId");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Almacenes",
                columns: new[] { "AlmacenId", "AlmacenDireccion", "AlmacenName" },
                values: new object[,]
                {
                    { "86c10bba-db71-440e-9a75-f4a95ea7ab76", "Frailes 2", "Almacen de Los Frailes 2" },
                    { "95061144-0e72-4586-8f63-4d0fb9827fba", "Frailes 1", "Almacen de Los Frailes 1 " },
                    { "c0d32e41-5f5f-4814-9f4f-1b683b06a696", "Por ahi", "Almacen central" },
                    { "f7413f13-22a4-4b8d-a2ba-03f4218750c1", "Tame Impala", "Almacen Tame Impala" }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "categoryId", "categoryName" },
                values: new object[,]
                {
                    { "ASH", "Aseo Hogar" },
                    { "ASP", "Aseo Personal" },
                    { "HGR", "Hogar" },
                    { "PRF", "Perfumeria" },
                    { "SLD", "Salud" },
                    { "VDJ", "Video Juegos" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_AlmacenId",
                table: "Bodegas",
                column: "AlmacenId");

            migrationBuilder.CreateIndex(
                name: "IX_Bodegas_ProductId",
                table: "Bodegas",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ingresosySalidas_BodegasBodegaId",
                table: "ingresosySalidas",
                column: "BodegasBodegaId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                column: "categoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ingresosySalidas");

            migrationBuilder.DropTable(
                name: "Bodegas");

            migrationBuilder.DropTable(
                name: "Almacenes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Category");
        }
    }
}
