namespace Assignment02;

internal class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = default!;
    public string Category { get; set; } = default!; // "Electronics", "Clothing", "Food", "Books" 
    public double Price { get; set; }
    public int Stock { get; set; }

    public static List<Product> SearchProducts (List<Product> list, Func<Product, bool> filter)
    {
        List<Product> result = new List<Product>();
        foreach (var product in list)
        {
            if (filter(product))
            {
                result.Add(product);
            }
        }
        return result;
    }

    public static void PrintReport(List<Product> list, Action<Product> action)
    {
        foreach (var product in list)
        {
            action(product);
        }
    }

    public static List<string> TransformProducts (List<Product> list, Func<Product, string> transformer)
    {
        List<string> result = new List<string>();
        foreach (var product in list)
        {
            result.Add(transformer(product));
        }
        return result;
    }

    public static List<Product> FilterProducts(List<Product> list, Predicate<Product> filter)
    {
        List<Product> result = new List<Product>();
        foreach (var product in list)
        {
            if (filter(product))
            {
                result.Add(product);
            }
        }
        return result;
    }

}