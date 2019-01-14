using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: Calculator
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(string txtFirst ,string txtSecond,string CallWCF)
        {
            CalculatorReference.CalculatorClient calc = new CalculatorReference.CalculatorClient();
            switch(CallWCF.ToUpper())
            {
                case "SUM":
                    ViewBag.Message = "The Summation of " + txtFirst + " and " + txtSecond + " is " + calc.Add(Convert.ToInt32(txtFirst), Convert.ToInt32(txtSecond));
                    break;
                case "SUBTRACT":
                    ViewBag.Message = "The Subtraction of " + txtFirst + " and " + txtSecond + " is " + calc.Subtract(Convert.ToInt32(txtFirst), Convert.ToInt32(txtSecond));
                    break;

            }
            return View();
        }
      
    }
}
