using System;
using System.Web.Mvc;
using SMS.Models.ParentInfoViewModel;
using SMS.Services.Providers;

namespace SMS.Controllers
{

    public class ParentInfoController : Controller
    {
        private readonly IParentInfoProvider _pro;
        public ParentInfoController()
        {
            _pro = new ParentInfoProvider();
        }
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            ParentInfoViewModel model = new ParentInfoViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(ParentInfoViewModel model)
        {
            try
            {
                _pro.Save(model);
            }
            catch (Exception e)
            {

            }

            return View(model);
        }
        public ActionResult Edit(int parentId)
        {
            ParentInfoViewModel model = new ParentInfoViewModel();
            model = _pro.Edit(parentId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(ParentInfoViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pro.Save(model);
            }
            return View(model);
        }
        public ActionResult Delete(int parentId)
        {
            _pro.Delete(parentId);
            return RedirectToAction("Index");
        }
    }
}


