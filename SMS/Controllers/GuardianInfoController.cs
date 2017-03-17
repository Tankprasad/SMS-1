using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMS.Models.GuardianInfoViewModel;
namespace SMS.Controllers
{
    public class GuardianInfoController : Controller
    {
        // GET: GuardianInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(GuardianInfoViewModel model)
        {
            return View(model);
        }
        public ActionResult Edit(int guardianId)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GuardianInfoViewModel model)
        {
            return View(model);
        }

        public ActionResult Delete(int guardianId)
        {
            return RedirectToAction("Index", "GuardianInfo");
        }
    }
}