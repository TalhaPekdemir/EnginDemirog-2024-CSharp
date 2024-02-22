namespace Day2Assignment2Linq;

internal class Program
{
    static void Main(string[] args)
    {
        List<Category> categories = new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Laptop"},
            new Category{CategoryId=2, CategoryName="Telefon"}
        };

        List<Product> products = new List<Product>
        {
            new Product { ProductId=1, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="32 GB ram", UnitPrice=30000, UnitsInStock=5},
            new Product { ProductId=2, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="16 GB ram", UnitPrice=10000, UnitsInStock=0},
            new Product { ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="32 GB ram", UnitPrice=20000, UnitsInStock=2},
            new Product { ProductId=4, CategoryId=2, ProductName="Asus Telefon", QuantityPerUnit="8 GB ram", UnitPrice=5000, UnitsInStock=10},
            new Product { ProductId=5, CategoryId=2, ProductName="Asus Telefon", QuantityPerUnit="8 GB ram", UnitPrice=15000, UnitsInStock=6},
        };

        Console.WriteLine("Bütün Ürünler:");
        foreach (var product in products)
        {
            Console.WriteLine(product.ProductName);
        }

        Console.WriteLine("\nFiltrelenmiş:");
        var result = products.Where(p => p.UnitPrice > 10000 && p.UnitsInStock > 2);
        foreach (var product in result)
        {
            Console.WriteLine(product.ProductName);
        }
    }

    static List<Product> GetProducts(List<Product> products)
    {
        return products.Where(p => p.UnitPrice > 10000 && p.UnitsInStock > 2).ToList();

    }


    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
