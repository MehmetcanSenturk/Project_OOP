using Microsoft.AspNetCore.Mvc;
using Proje_OOP.Entity;
using Proje_OOP.ProjeContext;

namespace Proje_OOP.Controllers
{
    public class ProductController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.tblProduct.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addproduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteProduct(int id)
        {
            var values = context.tblProduct.Where(x => x.Id == id).FirstOrDefault();
            context.Remove(values);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateProduct(int id) 
        { 
            var values = context.tblProduct.Where(x=>x.Id==id).FirstOrDefault();
            return View(values);
        }
        [HttpPost]
        public IActionResult Updateproduct(Product p)
        {
            var values = context.tblProduct.Where(x => x.Id ==p.Id).FirstOrDefault();
            values.Name= p.Name;
            values.price= p.price;
            values.Stock = p.Stock;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
