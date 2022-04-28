using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFServer.Data;
using WCFServer.Entity;

namespace WCFServer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private MyDbContext dbContext = new MyDbContext();    
        public Product Delete(int id)
        {
            var product = dbContext.Products.Find(id);
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
            return product;
        }

        public Product DeleteFind(int id)
        {
            var product = dbContext.Products.Find(id);
            return product;
        }

        public Product Edit(Product product)
        {
            dbContext.Entry(product).State = EntityState.Modified;
            dbContext.SaveChanges();
            return product;
        }

        public Product EditPrd(int id)
        {
            return dbContext.Products.Find(id);
        }

        public List<Product> GetList()
        {
            return dbContext.Products.ToList();
        }

        public Product Save(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
        } 
    }
}
