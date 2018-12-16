using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeaceLifeParty.Controllers
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
        public ActionResult Youth()
        {
            return View();
        }
        public ActionResult Employment()
        {
            return View();
        }
        public ActionResult Crime()
        {
            return View();
        }
        public ActionResult Criminals()
        {
            return View();
        }
        public ActionResult Economy()
        {
            return View();
        }
        public ActionResult Education()
        {
            return View();
        }
        public ActionResult Environment()
        {
            return View();
        }
        public ActionResult Health()
        {
            return View();
        }
        public ActionResult Aborigines()
        {
            return View();
        }
        public ActionResult Families()
        {
            return View();
        }
        public ActionResult Government()
        {
            return View();
        }
        public ActionResult Manufacturing()
        {
            return View();
        }
        public ActionResult Social()
        {
            return View();
        }
        public ActionResult OurIdeas()
        {
            return View();
        }
        public ActionResult SmallBusiness()
        {
            return View();
        }
        public ActionResult SocialPayments()
        {
            return View();
        }
        public ActionResult SpecialMentionEnergy()
        {
            return View();
        }
        public ActionResult BankUtilitiesPublicTransport()
        {
            return View();
        }
        public ActionResult MemberRegistration()
        {
            return View();
        }
        public ActionResult Comments()
        {
            return View();
        }
    }
}