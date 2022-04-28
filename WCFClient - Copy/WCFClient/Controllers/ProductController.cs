using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WCFClient.ServiceReference1;

namespace WCFClient.Controllers
{
    public class ProductController : Controller
    {
        static ServiceReference1.Service1Client service1Client = new ServiceReference1.Service1Client();
        // GET: Product
        public ActionResult Index()
        {
            var listProduct = service1Client.GetList();
            return View(listProduct);
        }
        public ActionResult ListProduct()
        {
            var listProduct = service1Client.GetList();
            return View(listProduct);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Save(Product product)
        {
            service1Client.Save(product);
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            service1Client.Edit(product);
            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var product = service1Client.EditPrd(id);
            return View(product);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirm(int id)
        {
            service1Client.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            var product = service1Client.DeleteFind(id);
            return View(product);
        }
    }
}