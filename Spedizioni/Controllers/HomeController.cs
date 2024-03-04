using System;
using System.Text.RegularExpressions;
using System.Web.Mvc;

namespace Spedizioni.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult CheckCodFiscale(string CodFisc)
        {
            string pattern = @"^[A-Z]{6}\d{2}[A-Z]\d{2}[A-Z]\d{3}[A-Z]$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(CodFisc))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult CheckPartitaIva(string PartitaIva)
        {
            string pattern = @"^\d{11}$";
            Regex regex = new Regex(pattern);
            if (regex.IsMatch(PartitaIva))
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        DateTime miaData = DateTime.Today;
        public ActionResult CheckDataSpedizione(DateTime data)
        {
            miaData = data;
            if (data >= DateTime.Today)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult CheckDataConsegna(DateTime data)
        {
            if (data > miaData)
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);
            }
        }

    }


}
}