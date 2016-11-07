using MVCandWCF.ServiceReference2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCandWCF.Controllers
{
    public class ProductsController : Controller
    {
        Service1Client _service = new Service1Client();
       
        public ActionResult GetProducts()
        {
            List<Product> products = _service.GetProducts().ToList(); ;
            return View(products);
        }


        /// <summary>
        /// Create section
        /// </summary>
        public ActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateProduct(Product _product)
        {            
                _service.CreateProduct(_product);
            
            return RedirectToAction("GetProducts" , "Products");
        }



        public ActionResult DeleteProduct(int id)
        {
            _service.DeleteProduct(id);
            return RedirectToAction("GetProducts", "Products");
        }



        /// <summary>
        /// Edit section
        /// </summary>
      
        public ActionResult EditProduct(int id)
        {
            Product product =  _service.GetProducts().FirstOrDefault(x => x.ProductId == id);

            return View(product);
        }
        [HttpPost]
        public ActionResult EditProduct(Product _product)
        {
            _service.EditProduct(_product);
            return RedirectToAction("GetProducts", "Products");
        }


    }
}