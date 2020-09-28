using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            SortedSet<string> regularGuests = new SortedSet<string>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "PARTY")
                {
                    break;
                }
                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }


            } while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                
                    vipGuests.Remove(input);
               
                    regularGuests.Remove(input);
                
            }
            regularGuests.UnionWith(vipGuests);
            Console.WriteLine(regularGuests.Count);
            if (regularGuests.Any())
            {
                foreach (var guest in regularGuests)
                {
                    Console.WriteLine(guest);
                }
            }
            
        }
    }
}
