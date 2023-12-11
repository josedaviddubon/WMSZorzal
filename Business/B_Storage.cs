﻿using DataAccess;
using Entities;
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