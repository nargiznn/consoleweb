
using ConsoleWeb;

AppDbContext appDbContext = new AppDbContext();
var products = appDbContext.Products.ToList();
foreach(var product in products)
{
    Console.WriteLine(product.Name + " " + product.Price);
}

