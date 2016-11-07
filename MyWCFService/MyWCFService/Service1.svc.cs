
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWCFService
{
    public class Service1 : IService1
    {
        ProductContext db = new ProductContext();
        public void CreateProduct(Product _product)
        {
           db.Products.Add(_product);
            db.SaveChanges();
            
        }

       

        public void DeleteProduct(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges(); 
        }

        public void EditProduct(Product _product)
        {
            db.Entry(_product).State = EntityState.Modified;
            db.SaveChanges();
           
        }

        public IEnumerable<Product> GetProducts()
        {
            List<Product> products = new List<Product>() ;
            products = db.Products.ToList();
            return products;
        }
    }
}
