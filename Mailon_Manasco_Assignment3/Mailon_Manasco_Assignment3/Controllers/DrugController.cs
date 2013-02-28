using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mailon_Manasco_Assignment3.ViewModels;

namespace Mailon_Manasco_Assignment3.Controllers
{
    public class DrugController : Controller
    {
        //
        // GET: /Drug/




        public ActionResult Checkout(CheckoutVM myCheckoutVM)
        {
            myCheckoutVM.Math();

            return View(myCheckoutVM);
        }

        public ActionResult Order()
        {
            ViewBag.Message = "ACE Order Page";

            return View();
        }

    }
}
