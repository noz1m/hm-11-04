using System;
using System.Collections.Generic;
using System.IO;

var path = @"/Users/nozimjonqozievgmail.com/Desktop/Sql/Hometask/homework4/File0/add.txt";

var lines = File.ReadAllLines(path);

var products = new List<Product>();

foreach (var line in lines)
{
    var parts = line.Split(',');

    var product = new Product()
    {
        Name = parts[0],
        Description = parts[1],
        Price = Convert.ToDecimal(parts[2]),
        StockQuantity = Convert.ToInt32(parts[3]),
        CategoryName = parts[4],
        CreatedDate = Convert.ToDateTime(parts[5])
    };
    products.Add(product);
}
foreach (var p in products)
{
    Console.WriteLine($"{p.Name} {p.Price} {p.Description} {p.StockQuantity} {p.CategoryName} {p.CreatedDate}");
}
Console.WriteLine($"Total Products: {products.Count}");

if (products.Count > 0)
{
    var averagePrice = products.Average(p => p.Price);
    Console.WriteLine($"Average Price: {averagePrice:F2}");
}
else
{
    Console.WriteLine("No products to calculate average price.");
}

var totalStockQuantity = products.Sum(p => p.StockQuantity);
Console.WriteLine($"Total Stock Quantity: {totalStockQuantity}");

var path1 = @"/Users/nozimjonqozievgmail.com/Desktop/Sql/Hometask/homework4/File0/product.txt";

var fileInfo = new FileInfo(path);
if (!fileInfo.Exists)
{
    Console.WriteLine(fileInfo.Name);
    Console.WriteLine(fileInfo.CreationTime);
    Console.WriteLine(fileInfo.Length);
}
else
{
    File.Create(path1);
}