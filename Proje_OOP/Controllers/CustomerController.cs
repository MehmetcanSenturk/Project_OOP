using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class CustomerController : Controller
    {
        Context context =new Context();
        public IActionResult Index()
        {
            var values = context.tblCustomer.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddCustomer(Customer p) {
            if (p.CustomerName.Length >= 3 && p.CustomerCity != "" && p.CustomerCity.Length >= 3)
            {

                context.Add(p);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            else
            {
                ViewBag.message = "Hatalı Kullanım";
                return View();
            } 
        }
        public IActionResult DeleteCustomer(int id)
        {
            var values =context.tblCustomer.Where(x=>x.CustomerID==id).FirstOrDefault();
            context.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCustomer(int id)
        { 
            var values = context.tblCustomer.Where(x=> x.CustomerID==id).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCustomer(Customer p)
        {
            var values = context.tblCustomer.Where(x=> x.CustomerID==p.CustomerID).FirstOrDefault();
            values.CustomerCity = p.CustomerCity;
            values.CustomerName = p.CustomerName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
