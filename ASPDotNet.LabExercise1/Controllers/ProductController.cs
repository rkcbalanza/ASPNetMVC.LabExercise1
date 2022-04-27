using ASPNetMVC.LabExercise1.Services;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetMVC.LabExercise1.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            this._productService = productService;
        }
        public IActionResult List()
        {
            ViewData["ProductList"] = this._productService.GetCatalog();
            ViewData["GrandTotal"] = this._productService.GetGrandTotal();
            return View();
        }
    }
}
