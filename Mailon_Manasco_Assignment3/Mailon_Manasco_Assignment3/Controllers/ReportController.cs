using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mailon_Manasco_Assignment3.Models;
using Mailon_Manasco_Assignment3.ViewModels;

namespace Mailon_Manasco_Assignment3.Controllers
{
    public class ReportController : Controller
    {
        private ACEEntities db = new ACEEntities();

        public ActionResult TopProduct()
        {
            List<TopProductVM> mylist = new List<TopProductVM>();

            mylist = db.Database.SqlQuery<TopProductVM>("SELECT Drug.Name as productName, Sum(OrderLine.quantity*OrderLine.UnitCost) as quantitySold FROM Drug INNER JOIN OrderLine ON Drug.DrugId = OrderLine.DrugId GROUP BY Drug.name ORDER BY 2 desc").ToList();
            return View(mylist.Take(5));
        }
    }
}

