using PeaceLifeParty.Areas.Admin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PeaceLifeParty.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        private VmMemberList model;
        public AdminController()
        {
            model = new VmMemberList();
        }
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult LoadData()
        {

            var draw = 0;// Request.Form.GetValues("draw").FirstOrDefault();
            var start = 0;// Request.Form.GetValues("start").FirstOrDefault();
            var length = 0;// Request.Form.GetValues("length").FirstOrDefault();
            var sortColumn = "";// Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
            var sortColumnDir = "";// Request.Form.GetValues("order[0][dir]").FirstOrDefault();

            var data = model.MemberList();
            //total number of rows count     
            var recordsTotal = data.Count();
            //Returning Json Data    
            //return View(model);
            return Json(new { data = data }, JsonRequestBehavior.AllowGet); 
        }
    }
}