using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Test_Evaluacion.Common.Entities;
using Test_Evaluacion.Web.Data;

namespace Test_Evaluacion.Web.Interfaces
{
    public class Products : IProduct
    {
        private readonly DataContext dataContext;

        public Products(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public void AddProduct(Product product)
        {
            dataContext.Products.Add(product);
            dataContext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var deleteFind = dataContext.Products.Find(id);
            dataContext.Products.Remove(deleteFind);
            dataContext.SaveChanges();
        }

        public List<Product> GetProducts()
        {
            return dataContext.Products.OrderBy(p => p.Name).ToList();
        }

        public void UpdateProduct(Product product)
        {
            dataContext.Entry(product).State = EntityState.Modified;
            dataContext.SaveChanges();
        }
    }
}
