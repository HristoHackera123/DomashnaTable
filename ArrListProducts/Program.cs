using System.Collections;

namespace ArrListProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList all = new ArrayList() {"Чушки", "Домати", 1.50, 5, 2, 2.20, 3.40, "Патладжани", 1 };
            List<string> products = new List<string>();
            List<double> prices = new List<double>();
            List<int> quant = new List<int>();
            for (int i = 0; i < all.Count; i++)
            {
                switch (all[i])
                {
                    case string:
                            products.Add((string)all[i]);
                            break;
                    case int:
                            quant.Add((int)all[i]);
                        break;
                    case double:
                            prices.Add((double)all[i]);
                        break;
                }
            }
            Console.WriteLine($"{"Продукти", -14}{"Цена", -10}{"Количество", -10}{"Сума", 6}");
            for (int i = 0;i < products.Count; i++)
            {
                Console.WriteLine($"{products[i],-14}{prices[i],-10}{quant[i], -10}{prices[i] * quant[i], 5}");
            }
        }
    }
}
