using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class B_InputOutput
    {
        public static List<InputOutputEntity> InOutsList()
        {
            using (var db = new ZorzalContext())
            {
                return db.InOuts.ToList();
            }
        }

        public static void CreateInOuts(InputOutputEntity oInOuts)
        {
            using (var db = new ZorzalContext())
            {
                db.InOuts.Add(oInOuts);
                db.SaveChanges();
            }
        }

        public static void UpdateInOuts(InputOutputEntity oInOuts)
        {
            using (var db = new ZorzalContext())
            {
                db.InOuts.Update(oInOuts);
                db.SaveChanges();
            }
        }
    }
}
