using System.Web.Mvc;
using SMS.Models.SetupViewModel;
using SMS.Services.Providers;


namespace SMS.Controllers
{
    public class SetupSubjectsController : Controller
    {

        private readonly ISetupSubjectProvider _pro;
        public SetupSubjectsController()
        {
            this._pro = new SetupSubjectProvider();
        }
        public ActionResult Index()
        {
            SetupSubjectViewModel model = new SetupSubjectViewModel();
            model = _pro.GetList();
            return View(model);
        }
        public ActionResult Create()
        {
            SetupSubjectViewModel model = new SetupSubjectViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(SetupSubjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pro.Save(model);
            }
            return View(model);
        }

        public ActionResult Edit(int subjectId)
        {
            SetupSubjectViewModel model = new SetupSubjectViewModel();
            model = _pro.GetSubjectInfoById(subjectId);
            return View(model);
        }
        [HttpPost]
        public ActionResult Edit(SetupSubjectViewModel model)
        {
            if (ModelState.IsValid)
            {
                _pro.Save(model);
            }
            return View(model);
        }


    }
}