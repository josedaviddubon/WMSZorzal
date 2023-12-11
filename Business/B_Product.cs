using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_Product
    {
        public static List<ProductEntity> ProductList()
        {
            using (var db = new ZorzalContext())
            {
                return db.Products.ToList();
            }
        }

        
        public static ProductEntity ProductById(string id)
        {
            using (var db = new ZorzalContext())
            {
                return db.Products.LastOrDefault(c => c.ProductId == id);
            }
        }

        public static void CreateProducts(ProductEntity oProducts)
        {
            using (var db = new ZorzalContext())
            {
                db.Products.Add(oProducts);
                db.SaveChanges();
            }
        }

        public static void UpdateProducts(ProductEntity oProducts)
        {
            using (var db = new ZorzalContext())
            {
                db.Products.Update(oProducts);
                db.SaveChanges();
            }
        }
    }
}
