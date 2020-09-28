using System;
using System.Collections.Generic;
using System.Linq;

namespace Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> marketsDict = new Dictionary<string, Dictionary<string, double>>();
            string input;
            while ((input = Console.ReadLine()) != "Revision")
            {
                var tokens = input.Split(", ");
                var shop = tokens[0];
                var product = tokens[1];
                var price = double.Parse(tokens[2]);

                if (!marketsDict.ContainsKey(shop))
                {
                    marketsDict.Add(shop, new Dictionary<string, double>());
                    marketsDict[shop].Add(product, price);
                }
                else if (marketsDict.ContainsKey(shop))
                {
                    marketsDict[shop].Add(product, price);
                }
          

            }
            var markets = marketsDict.OrderBy(x => x.Key);
            foreach (var market in markets)
            {
                Console.WriteLine($"{market.Key}->");
                foreach (var item in market.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
