using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddDataTwo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "0fc2dfb9-55ae-4b1d-b5ed-37bc4de5cab0");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "66258d5a-5a5f-4dc3-859c-1b1e0e045a85");

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "2dba6292-2403-41f4-b696-fded8d16b9f1", "Calle 33", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "9ae0518d-003e-41aa-a562-f3dc2df9a16b", "Calle Uno", "Bodega Central" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "2dba6292-2403-41f4-b696-fded8d16b9f1");

            migrationBuilder.DeleteData(
                table: "WareHouses",
                keyColumn: "WarehouseID",
                keyValue: "9ae0518d-003e-41aa-a562-f3dc2df9a16b");

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "0fc2dfb9-55ae-4b1d-b5ed-37bc4de5cab0", "Calle 33", "Bodega Norte" });

            migrationBuilder.InsertData(
                table: "WareHouses",
                columns: new[] { "WarehouseID", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "66258d5a-5a5f-4dc3-859c-1b1e0e045a85", "Calle Uno", "Bodega Central" });
        }
    }
}
