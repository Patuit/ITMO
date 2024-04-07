using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using CommonLibrary;

namespace HW16_1;

class Program
{
    static void Main(string[] args)
    {
        List<Product> listProduct = new List<Product>();
        do
        {
            int codeProduct;
            string? nameProduct;
            double priceProduct;

            do
            {
                try
                {
                    Console.WriteLine("Введите код товара:");
                    codeProduct = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Код товара введён неверно. Попробуйте ещё раз");
                }
            } while (true);
            do
            {
                try
                {
                    Console.WriteLine("Введите наименование товара:");
                    nameProduct = Console.ReadLine();
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Наименование товара введено неверно. Попробуйте ещё раз");
                }
            } while (true);
            do
            {
                try
                {
                    Console.WriteLine("Введите цену товара:");
                    priceProduct = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    Console.WriteLine("Цена товара введена неверно. Попробуйте ещё раз");
                }
            } while (true);

            listProduct.Add(new Product() { CodeProduct = codeProduct, NameProduct = nameProduct, PriceProduct = priceProduct });

            Console.WriteLine("Введите 'q' для завершения ввода или любой символ для продолжения:");
            string? endAnswer = Console.ReadLine();
            if (endAnswer == "q")
            {
                break;
            }
        } while (true);

        JsonSerializerOptions options = new JsonSerializerOptions() {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize(listProduct, options);
        Console.WriteLine("JSON = " + jsonString);

        using (StreamWriter sw = new StreamWriter("../Product.json"))
        {
            sw.WriteLine(jsonString);
        }
    }
}
