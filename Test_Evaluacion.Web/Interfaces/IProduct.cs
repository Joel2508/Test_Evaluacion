using System.Collections.Generic;
using Test_Evaluacion.Web.Data.Entities;

namespace Test_Evaluacion.Web.Interfaces
{
    public interface IProduct
    {
        List<Product> GetProducts();
        void AddProduct(Product product);
        void DeleteProduct(int id);
        void UpdateProduct(Product product);

        Product SelectProduct(int? id);
    }
}
