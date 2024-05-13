
using WebAPIServices.Models;

namespace WebAPIServices.Services.ProductServices
{
    
    public class ProductService : IProductService
    {
        private static List<Product> products = new List<Product>
            {
                new Product{
                    Id=1,
                    Name = "Laptop HP Omen 16",
                    Price=37290,
                    Category = "Laptop",
                    Color = "black",
                    Description="HP Omen 16 laptop n0087AX R7 ",
                    Image= "https://www.omen.com/content/dam/sites/omen/worldwide/laptops/hero-banner-desktop-i7-3-new-image.png"
                },
                new Product{
                    Id=2,
                    Name = "Laptop Apple MacBook Air",
                    Price=37290,
                    Category = "Laptop",
                    Color = "yellow",
                    Description="13 inch M2 16GB/512GB/10GPU (Z15Z0003L) ",
                    Image= "https://tse4.mm.bing.net/th?id=OIP.Gugj6FOZ22QOi6iH2rTQSgHaE8&pid=Api&P=0&h=180g"
                },

            };
        public List<Product> AddProduct(Product product)
        {
            products.Add(product);
            return products;
        }

        public List<Product>? DeleteProduct(int id)
        {
            var product = products.Find(x => x.Id == id);
            if (product is null)
                return null;
            products.Remove(product);
            return products;
        }

        public List<Product> GetAllProducts()
        {
            return products;
        }

        public Product? GetSingleProduct(int id)
        {
            var product = products.Find(x => x.Id == id);
            if (product is null)
                return null;
            return product;
        }

        public List<Product>? UpdateProduct(int id, Product request)
        {
            var product = products.Find(x => x.Id == id);
            if (product is null)
                return null;
            product.Name = request.Name;
            product.Price = request.Price;
            product.Category = request.Name;
            product.Color = request.Color;
            product.Image = request.Image;
            product.Description = request.Description;
            return products;
        }
    }
}
