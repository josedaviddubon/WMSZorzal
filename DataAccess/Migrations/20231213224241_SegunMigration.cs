using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class SegunMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "41b56640-313f-4cd0-af71-2a8a569bdd61");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "b60f3c6a-c5ad-44bd-9dd8-75c860129f95");

            migrationBuilder.RenameColumn(
                name: "IsOut",
                table: "InOuts",
                newName: "IsInput");

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "0fc2dfb9-55ae-4b1d-b5ed-37bc4de5cab0", "Calle 33", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "66258d5a-5a5f-4dc3-859c-1b1e0e045a85", "Calle Uno", "Bodega Central" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "0fc2dfb9-55ae-4b1d-b5ed-37bc4de5cab0");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "66258d5a-5a5f-4dc3-859c-1b1e0e045a85");

            migrationBuilder.RenameColumn(
                name: "IsInput",
                table: "InOuts",
                newName: "IsOut");

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "41b56640-313f-4cd0-af71-2a8a569bdd61", "Calle Uno", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "b60f3c6a-c5ad-44bd-9dd8-75c860129f95", "Calle 33", "Bodega Norte" });
        }
    }
}
