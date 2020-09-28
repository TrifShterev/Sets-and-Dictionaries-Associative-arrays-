using System;
using System.Collections.Generic;

namespace Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, List<string>>> worldGeograficalDict = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                var continent = input[0];
                var country = input[1];
                var city = input[2];

                if (!worldGeograficalDict.ContainsKey(continent))
                {
                    worldGeograficalDict.Add(continent, new Dictionary<string, List<string>>());
                    
                    
                }
                if (!worldGeograficalDict[continent].ContainsKey(country))
                {
                    worldGeograficalDict[continent].Add(country, new List<string>());
                    
                }
               
                    worldGeograficalDict[continent][country].Add(city);
                

            }
            foreach (var (key,value) in worldGeograficalDict)
            {
                Console.WriteLine($"{key}:");
                foreach (var country in value)
                {
                    Console.WriteLine($" {country.Key} -> {string.Join(", ",country.Value)} ");

                    
                }
                
            }
        }
    }
}
