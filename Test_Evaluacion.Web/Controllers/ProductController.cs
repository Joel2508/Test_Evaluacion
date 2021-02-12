using Microsoft.AspNetCore.Mvc;
using Test_Evaluacion.Web.Data.Entities;
using Test_Evaluacion.Web.Interfaces;

namespace Test_Evaluacion.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct product;

        public ProductController(IProduct product)
        {
            this.product = product;
        }

        public IActionResult Index()
        {
            return View(product.GetProducts());
        }

        public ActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                product.AddProduct(model);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public ActionResult EditProduct(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var selectproduct = product.SelectProduct(id);

            return View(selectproduct);

        }

        [HttpPost]
        public ActionResult EditProduct(Product model)
        {
            if (ModelState.IsValid)
            {
                product.UpdateProduct(model);
                return RedirectToAction(nameof(Index));
            }
            return View();

        }




        public ActionResult DeleteProdct(int id)
        {
            product.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }


    }
}
