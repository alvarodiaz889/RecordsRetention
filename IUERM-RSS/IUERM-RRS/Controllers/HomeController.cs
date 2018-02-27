using IUERM_RRS.Repositories;
using IUERM_RRS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IUERM_RRS.Controllers
{
    public class HomeController : Controller
    {
        private IMainRepository mainRepository;
        public HomeController(IMainRepository mainRepository)
        {
            this.mainRepository = mainRepository;
        }

        [Authorize]
        public ActionResult Index()
        {
            ScheduleViewModel.SetColumns(mainRepository.GetColumnsConfig());
            ScheduleViewModel.Checked = false;
            return View();
        }
        [Authorize]
        public ActionResult AdvancedView(string check)
        {
            ScheduleViewModel.SetColumns(mainRepository.GetColumnsConfig());
            ScheduleViewModel.Checked = Convert.ToBoolean(check);
            return View("Index");
        }

        public ActionResult LoginError()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}