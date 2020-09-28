using System;
using System.Collections.Generic;
using System.Linq;

namespace Parking_Lot_HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            string input;
            while ((input=Console.ReadLine())!="END")
            {
                string[] tokens = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var direction = tokens[0];
                var carNumber = tokens[1];

                if (direction=="IN")
                {
                    parkingLot.Add(carNumber);
                }
                else if (direction=="OUT")
                {
                    parkingLot.Remove(carNumber);
                }
            }
            if (parkingLot.Any())
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
