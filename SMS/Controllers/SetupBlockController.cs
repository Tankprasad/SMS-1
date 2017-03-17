using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMS.Models.SetupViewModel;
using SMS.Service.Providers.SetupProviders;

namespace SMS.Controllers
{
    public class SetupBlockController : Controller
    {
        private readonly ISetupBlockProvider _pro;
        public SetupBlockController()
        {
            this._pro = new SetupBlockProvider();

        }


        public ActionResult Index()
        {
            SetupBlockViewModel model = new SetupBlockViewModel();
            model = _pro.GetBlockList();
            return View(model);
        }
        public ActionResult Create()
        {
            SetupBlockViewModel model = new SetupBlockViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(SetupBlockViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pro.Save(model);
            }
            return RedirectToAction("Index");

        }
        public ActionResult Edit(int blockId)
        {
            SetupBlockViewModel model = new SetupBlockViewModel();
            return View(model);

        }
        [HttpPost]
        public ActionResult Edit(SetupBlockViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pro.Save(model);
            }
            return RedirectToAction("Index");

        }
        public ActionResult Delete(int blokId)
        {
            _pro.Delete(blokId);
            return RedirectToAction("Index");
        }


    }
}