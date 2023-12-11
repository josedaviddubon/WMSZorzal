using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_WareHouse
    {
        public static List<WarehouseEntity> WarehouseList()
        {
            using (var db = new ZorzalContext())
            {
                return db.WareHouses.ToList();
            }
        }

        public static void CreateWarehouse(WarehouseEntity oWareHouses)
        {
            using (var db = new ZorzalContext())
            {
                db.WareHouses.Add(oWareHouses);
                db.SaveChanges();
            }
        }

        public static void UpdateWarehouse(WarehouseEntity oWareHouses)
        {
            using (var db = new ZorzalContext())
            {
                db.WareHouses.Update(oWareHouses);
                db.SaveChanges();
            }
        }
    }
}
