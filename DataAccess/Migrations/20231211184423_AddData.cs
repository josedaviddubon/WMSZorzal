using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "CategoryName" },
                values: new object[,]
                {
                    { "CAT001", "Materiales de Construcción" },
                    { "CAT002", "Herramientas y Equipos" },
                    { "CAT003", "Maquinaria Pesada" },
                    { "CAT004", "Diseño Arquitectónico" },
                    { "CAT005", "Estructuras Metálicas" },
                    { "CAT006", "Sistemas Eléctricos" },
                    { "CAT007", "Climatización y Ventilación" },
                    { "CAT008", "Construcción Residencial" },
                    { "CAT009", "Construcción Comercial" },
                    { "CAT010", "Gestión de Proyectos" }
                });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "41b56640-313f-4cd0-af71-2a8a569bdd61", "Calle Uno", "Bodega Central" },
                    { "b60f3c6a-c5ad-44bd-9dd8-75c860129f95", "Calle 33", "Bodega Norte" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "ProductDescription", "ProductName", "TotalQuantity" },
                values: new object[] { "PROD001", "CAT001", "Ladrillos de alta resistencia para construcción", "Ladrillos Cerámicos", 100 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "ProductDescription", "ProductName", "TotalQuantity" },
                values: new object[] { "PROD002", "CAT002", "Martillo percutor para trabajos de demolición", "Martillo Eléctrico", 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryID", "ProductDescription", "ProductName", "TotalQuantity" },
                values: new object[] { "PROD003", "CAT003", "Excavadora para movimientos de tierra", "Excavadora Caterpillar", 5 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT004");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT005");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT006");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT007");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT008");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT009");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT010");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "PROD001");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "PROD002");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "PROD003");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "41b56640-313f-4cd0-af71-2a8a569bdd61");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "b60f3c6a-c5ad-44bd-9dd8-75c860129f95");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT001");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT002");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryID",
                keyValue: "CAT003");
        }
    }
}
