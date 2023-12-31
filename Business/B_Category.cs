﻿using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Category
    {
        public static List<CategoryEntity> CategoryList()
        {
            using(var db = new ZorzalContext())
            {
                return db.Categories.ToList();
            }
        }

        public static CategoryEntity CategoryById(string id)
        {
            using (var db = new ZorzalContext())
            {
                return db.Categories.ToList().LastOrDefault(c => c.CategoryID == id);
            }
        }
        public static void CreateCategory(CategoryEntity oCategory)
        {
            using(var db = new ZorzalContext())
            {
                db.Categories.Add(oCategory);
                db.SaveChanges();
            }
        }

        public static void UpdateCategory(CategoryEntity oCategory)
        {
            using(var db = new ZorzalContext())
            {
                db.Categories.Update(oCategory);
                db.SaveChanges();
            }
        }
    }
}
