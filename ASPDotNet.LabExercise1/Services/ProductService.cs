using ASPNetMVC.LabExercise1.Models;
using System.Collections.Generic;

namespace ASPNetMVC.LabExercise1.Services
{
    public class ProductService
    {
        private List<Product> products;

        public ProductService()
        {
            products = new List<Product>();
            products.Add(new Product()
            {
                Id = 1,
                Name = "24-inch Monitor",
                Description = "165hz Full HD Monitor",
                Quantity = 3,
                Price = 15_000M
            });
            products.Add(new Product()
            {
                Id = 2,
                Name = "Mechanical Keyboard",
                Description = "TKL Keyboard",
                Quantity = 2,
                Price = 8_000M
            });
            products.Add(new Product()
            {
                Id = 3,
                Name = "Gaming Mouse",
                Description = "16,000 DPI Mouse",
                Quantity = 2,
                Price = 6_000M
            });
            products.Add(new Product()
            {
                Id = 4,
                Name = "Extended Mousepad",
                Description = "120x70cm RGB Mousepad",
                Quantity = 2,
                Price = 1_000M
            });
            products.Add(new Product()
            {
                Id = 5,
                Name = "Soundbar",
                Description = "100cm Soundbar",
                Quantity = 1,
                Price = 26_000M
            });
            products.Add(new Product()
            {
                Id = 6,
                Name = "Webcam",
                Description = "4K Streaming Webcam",
                Quantity = 2,
                Price = 11_000M
            });
        }

        public List<Product> GetCatalog()
        {
            return products;
        }
        public decimal GetGrandTotal()
        {
            List<Product> products = this.GetCatalog();

            decimal grandTotal = 0;

            foreach (Product product in products)
            {
                grandTotal += product.TotalAmount;
            }

            return grandTotal;
    }

    }
}
