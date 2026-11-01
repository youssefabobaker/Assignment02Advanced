namespace Assignment02;

internal class Program
{
    static void Main(string[] args)
    {
        List<Product> catalog = new()
        {
            new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
            new Product { Id=2,Name="Phone", Category="Electronics", Price=800, Stock=25 },
            new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
            new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
            new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
            new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
            new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
            new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
            new Product { Id=9,Name="Headphones", Category="Electronics", Price=150,Stock=15 }
        };

        #region Task 01 : Smart Product Search
        //List<Product> electronics = Product.SearchProducts(catalog, p => p.Category == "Electronics");
        //Console.WriteLine("-- Electronics --");
        //foreach (var product in electronics)
        //{
        //    Console.WriteLine($"{product.Name} - ${product.Price} - (Stock: {product.Stock})");
        //}
        //Console.WriteLine();

        //List<Product> cheapProducts = Product.SearchProducts(catalog, p => p.Price < 50);
        //Console.WriteLine("-- Under 50$ --");
        //foreach (var product in cheapProducts)
        //{
        //    Console.WriteLine($"{product.Name} - ${product.Price} - (Stock: {product.Stock})");
        //}
        //Console.WriteLine();

        //List<Product> inStock = Product.SearchProducts(catalog, p => p.Stock > 0);
        //Console.WriteLine("-- In Stock --");
        //foreach (var product in inStock)
        //{
        //    Console.WriteLine($"{product.Name} - ${product.Price} - (Stock: {product.Stock})");
        //}
        //Console.WriteLine();

        //List<Product> cheapClothing = Product.SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);
        //Console.WriteLine("-- Cheap Clothing --");
        //foreach (var product in cheapClothing)
        //{
        //    Console.WriteLine($"{product.Name} - ${product.Price} - (Stock: {product.Stock})");
        //}
        //Console.WriteLine();
        #endregion

        #region Task 03 : Custom Report Generator

        #region 3.1  Print Reports 
        //Console.WriteLine("-- Short Report --");
        //Product.PrintReport(catalog, product => Console.WriteLine($"{product.Name} - ${product.Price}"));
        //Console.WriteLine();

        //Console.WriteLine("-- Detailed Report --");
        //Product.PrintReport(catalog, product => Console.WriteLine($"[{product.Category}] {product.Name} | ${product.Price} | Stock: {product.Stock}"));
        #endregion

        #region 3.2. Transform Products 
        //List<string> productSummary = Product.TransformProducts(catalog, product => String.Format("{0} $({1})", product.Name, product.Price));
        //Console.WriteLine("-- Summary List --");
        //foreach (var product in productSummary)
        //{
        //    Console.WriteLine(product);
        //}

        //Console.WriteLine();

        //List<string> productpricelabel = Product.TransformProducts(catalog, product => String.Format("{0}: {1}!", product.Name, product.Price>100 ? "Expensive" : "Affordable"));
        //Console.WriteLine("-- Price Labels  --");
        //foreach (var product in productpricelabel)
        //{
        //    Console.WriteLine(product);
        //}
        #endregion

        #region 3.3. Filter Products 
        //List<Product> lowstockproduct = Product.FilterProducts(catalog, product => product.Stock < 20);
        //Console.WriteLine("-- Low-Stock Alert --");
        //foreach (var product in lowstockproduct)
        //{
        //    Console.WriteLine($"[LOW STOCK] {product.Name}: only {product.Stock} left!");
        //}
        #endregion

        #endregion
    }
}
