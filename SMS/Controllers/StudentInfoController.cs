using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMS.Models.StudentInfoViewModel;
using SMS.Service.Providers.StudentInfoProvider;

namespace SMS.Controllers
{

    public class StudentInfoController : Controller
    {
        private readonly IStudentInfoProvider _pro;
        public StudentInfoController()
        {
            this._pro = new StudentInfoProvider();
        }
        public ActionResult Index()
        {
            StudentInfoViewModel model = new StudentInfoViewModel();
            model = _pro.GetList();
            return View();
        }
        public ActionResult Create()
        {
            StudentInfoViewModel model = new StudentInfoViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(StudentInfoViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pro.Save(model);
            }
            return View(model);
        }
        public ActionResult Edit(int studentId)
        {
            StudentInfoViewModel model = new StudentInfoViewModel();
            model = _pro.Edit(studentId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(StudentInfoViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pro.Save(model);
            }
            return View(model);
        }

        public ActionResult Delete(int studentId)
        {
            StudentInfoViewModel model = new StudentInfoViewModel();
            model = _pro.Delete(studentId);
            return View(model);
        }
    }
}