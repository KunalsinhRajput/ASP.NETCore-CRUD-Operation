using CRUDCoreOperations.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUDCoreOperations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public EmpContext e1;
        public HomeController(ILogger<HomeController> logger,EmpContext e1)
        {
            _logger = logger;
            this.e1 = e1;
        }

        public IActionResult Index()
        {
            var t = e1.Emps.ToList();
            return View(t);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(string Ename,string Eaddress,string MobileNo)
        {
            
                Emp e = new Emp();
                e.Ename = Ename;
                e.Eaddress = Eaddress;
                e.MobileNo = MobileNo;

                e1.Emps.Add(e);
                e1.SaveChanges();
                return RedirectToAction("Index");
            
            
        }
        public IActionResult Details(int id)
        {
            var t = e1.Emps.Where(x => x.Eid == id).FirstOrDefault();
            return View(t);
        }
       public IActionResult Delete(int id) 
        {
            var t = e1.Emps.Where(x => x.Eid == id).FirstOrDefault();
            e1.Emps.Remove(t);
            e1.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var t = e1.Emps.Where(x => x.Eid == id).FirstOrDefault();
            return View(t);
        }
        [HttpPost]
        public IActionResult Edit(int id, string Ename, string Eaddress, string MobileNo)
        {
            var t = e1.Emps.Where(x => x.Eid == id).FirstOrDefault();
            Emp e2 = new Emp();
            e2.Ename = Ename;
            e2.Eaddress = Eaddress;
            e2.MobileNo = MobileNo;
            e1.Emps.Update(e2);
            e1.SaveChanges();
            return RedirectToAction("Index");


          
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
