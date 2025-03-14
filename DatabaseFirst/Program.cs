using DatabaseFirst.Contextx;
using DatabaseFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region StoredProcedures
            var optionsBuilder = new DbContextOptionsBuilder<NorthwindContext>();
            optionsBuilder.UseSqlServer(".");

            using (NorthwindContext context = new NorthwindContext(optionsBuilder.Options))
            {
                NorthwindContextProcedures contextProcedures = new NorthwindContextProcedures(context);
                var products = contextProcedures.SalesByCategoryAsync("Beverages" , "1998").Result;
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.ProductName} - {product.ProductName} - {product.TotalPurchase}");
                }
            }
            #endregion

            #region Run Sql Query
            using (NorthwindContext context = new NorthwindContext(optionsBuilder.Options))
            {
                var products = context.Products.FromSqlRaw("SELECT * FROM Products").ToList();
                foreach (var product in products)
                {
                    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
                }
                context.Database.ExecuteSqlRaw("UPDATE Products SET UnitPrice = UnitPrice * 1.1");
            }
            #endregion
            #region LazyLoading
            using (NorthwindContext context = new NorthwindContext(optionsBuilder.Options))
            {
                var products = context.Products.FirstOrDefault();
                context.Entry(products).Reference(p => p.Category).Load();

            }

            #endregion

            #region Remote  Vs Local
            using (NorthwindContext context = new NorthwindContext(optionsBuilder.Options))
            {
                context.Products.Load();

                if (context.Products.Local.Any(x => x.UnitsInStock == 0))
                    Console.WriteLine("There are products with 0 stock");
                else
                Console.WriteLine("There are no products with 0 stock");
            }

            #endregion

        }
    }
}
