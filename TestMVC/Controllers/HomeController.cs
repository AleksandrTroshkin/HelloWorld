using Domain.Services;
using System.Collections.Generic;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestTableService Service;

        public HomeController(ITestTableService service)
        {
            Service = service;
        }

        public ActionResult Index()
        {
            var test = Service.FindAll();
            var model = new List<TestTableModel>();
            foreach (var item in test)
                model.Add(new TestTableModel { Id = item.TestTableId, Text = item.TestTableText });

            return View(model.ToArray());
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
    }
}