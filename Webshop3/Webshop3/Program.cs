using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using Webshop.Models;

namespace Webshop3
{

    internal class Program
    {
        static void Main(string[] args)
        {
            IConfigurationRoot config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();

            string? ConnectionString = config.GetConnectionString("DefaultConnection");

            Console.WriteLine("Hello, World!");


            string connectionString = ConnectionString;
            IRepository<Product> productRepository = new ProductRepository(connectionString);

            // Adding a new semester
            productRepository.Add(new Product { ProductName = "2024", CategoryID = 1 });

            // Getting all semesters
            var products = productRepository.GetAll();
            foreach (var product in products)
            {
                Console.WriteLine($"Product ID: {product.ProductID}, ProductName: {product.ProductName}");
            }

            // Updating a semester
            var firstProduct = productRepository.GetById(1);
            if (firstProduct != null)
            {
                firstProduct.ProductName = "2025";
                productRepository.Update(firstProduct);
            }

            // Deleting a semester
            productRepository.Delete(1);
        }
    }
}
