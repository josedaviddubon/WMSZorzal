using DataAccess;
using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Storage
    {
        public static List<StorageEntity> StorageList()
        {
            using (var db = new ZorzalContext())
            {
                return db.Storages.ToList();
            }
        }

        public static void CreateStorage(StorageEntity oStorages)
        {
            using (var db = new ZorzalContext())
            {
                db.Storages.Add(oStorages);
                db.SaveChanges();
            }
        }

        public static bool IsProductInWareHouse(string IdStorage)
        {
            using (var db = new ZorzalContext())
            {
                var product = db.Storages.ToList()
                    .Where(s => s.StorageId== IdStorage);
                return product.Any();
            }
        }

        public static List<StorageEntity> StorageProductByWareHouse(string idWareHouse)
        {
            using (var db = new ZorzalContext())
            {
                return db.Storages.
                    Include(s=> s.Product)
                    .Include(s=> s.Warehouse)
                    .Where(s=> s.WarehouseID == idWareHouse)
                    .ToList();
            }
        }

        public static void UpdateStorage(StorageEntity oStorages)
        {
            using (var db = new ZorzalContext())
            {
                db.Storages.Update(oStorages);
                db.SaveChanges();
            }
        }
    }
}
