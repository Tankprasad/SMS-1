using System.Web;
using System.Web.Mvc;
using SMS.Models.StudentInfoViewModel;
using System.IO;

using SMS.Services.Providers;
namespace SMS.Controllers.StudentInfoController
{
    
    public class StudentInfoController : Controller
    {
        private readonly IStudentInfoProvider _pro;
        public StudentInfoController()
        {
            _pro = new StudentInfoProvider();
        }
        // GET: StudentInfo
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
        public ActionResult Create(StudentInfoViewModel model)
        {
            return View(model);
        }
        public ActionResult Edit(int studentId)
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(StudentInfoViewModel model)
        {
            return View(model);
        }

        public ActionResult Delete(int studentId)
        {
            return RedirectToAction("Index", "StudentInfo");
        }
    }
}