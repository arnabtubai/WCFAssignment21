using MVCFirst.HttpReference;
using MVCFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirst.Controllers
{
    public class WCF1Controller : Controller
    {
        // GET: WCF1
        public ActionResult Index()
        {
            return View();
        }

       

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(WCF1Models mdl,string CallWCF)
        {
            if (CallWCF.ToUpper().Equals("INVOKE AS TCP"))
            {
                try
                {
                    MVCFirst.tcpReference.MyServiceClient myService = new MVCFirst.tcpReference.MyServiceClient();
                
                    mdl.Message = myService.SayHello(mdl.Name) + "--" + myService.TodayProgram(mdl.Name);
                    ViewBag.Message = mdl.Message;
                    return View("Index");
                }
                catch
                {
                    return View();
                }
            }
            else
            {
                try
                {
                    MyServiceClient myService = new MyServiceClient();
                
                    mdl.Message = myService.SayHello(mdl.Name) + "--" + myService.TodayProgram(mdl.Name);
                    ViewBag.Message = mdl.Message;
                    return View("Index");
                }
                catch
                {
                    return View();
                }
            }
        }
        
    }
}
