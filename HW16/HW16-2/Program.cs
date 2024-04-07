

using System.Text.Json;
using CommonLibrary;

namespace HW16_2;

class Program
{
    static void Main(string[] args)
    {
        string jsonString = String.Empty;
        using (StreamReader sr = new StreamReader("../Product.json"))
        {
            jsonString = sr.ReadToEnd();
        }

        List<Product>? productList = JsonSerializer.Deserialize<List<Product>>(jsonString);

        Product expensiveProduct = productList[0];
        foreach (Product item in productList)
        {
            if (item.PriceProduct > expensiveProduct.PriceProduct)
            {
                expensiveProduct = item;
            }
        }
        Console.WriteLine($"Самый дорогой товар называется: {expensiveProduct.NameProduct}");
    }
}
