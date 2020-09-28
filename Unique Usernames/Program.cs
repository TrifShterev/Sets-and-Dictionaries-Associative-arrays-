using System;
using System.Collections.Generic;

namespace Unique_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> usernames = new HashSet<string>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string user = Console.ReadLine();
                usernames.Add(user);
            }
            foreach (var name in usernames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
