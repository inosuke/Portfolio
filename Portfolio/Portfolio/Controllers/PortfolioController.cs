using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        // GET: Portfolio
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Factory()
        {
            // ＰＣ／スマホで呼び出しHTMLの分岐
            var userAgent = Request.UserAgent;
            string viewName = "";
            if (IsSmapho(userAgent))
            {
                viewName = "FactoryForiPad";
            }
            else
            {
                viewName = "Factory";
            }
            return View(viewName);
        }

        private static bool IsSmapho(string userAgent)
        {
            var isSmapho = false;
            if (userAgent.IndexOf("iPhone") > -1)
            {
                isSmapho = true;
            }
            else if (userAgent.IndexOf("iPad") > -1)
            {
                isSmapho = true;
            }
            else if (userAgent.IndexOf("iPod") > -1)
            {
                isSmapho = true;
            }
            else if (userAgent.IndexOf("Android") > -1)
            {
                isSmapho = true;
            }
            return isSmapho;
        }
    }
}