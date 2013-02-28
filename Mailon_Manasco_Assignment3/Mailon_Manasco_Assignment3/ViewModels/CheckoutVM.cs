using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mailon_Manasco_Assignment3.ViewModels
{
    public class CheckoutVM
    {
        public int tylenol { get; set; }
        public int ibuprofren { get; set; }
        public int aspirin { get; set; }
        public double subtotal { get; set; }
        public double tax { get; set; }
        public double total { get; set; }
        public bool hasParameter { get; set; }
        public double tyTotal { get; set; }
        public double ibTotal { get; set; }
        public double asTotal { get; set; }

        public void Math()
        {
            tyTotal = System.Math.Round(tylenol * 1.99,2);
            ibTotal = System.Math.Round(ibuprofren * .99,2);
            asTotal = System.Math.Round(aspirin * 1.49,2);
            subtotal = System.Math.Round(tylenol * 1.99 + aspirin * 1.49 + ibuprofren * .99,2);
            tax = System.Math.Round(subtotal * .08,2);
            total = System.Math.Round(subtotal + tax,2);
            hasParameter = true;
        }


    }
}