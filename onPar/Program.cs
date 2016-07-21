using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onPar
{
    class Program
    {
        static void Main(string[] args)
        {
            string response = "no";
            int total = 0;
            List<int> numList = new List<int>();
            do
            {

                Console.WriteLine($"Current Total: {total}.");
                Console.WriteLine("Enter a number to add to the total.");
                response = Console.ReadLine();
                int intResponse = int.Parse(response);
                numList.Add(intResponse);
                total += intResponse;
                Console.Write("So far you have entered: ");
                foreach (int i in numList)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
                Console.WriteLine($"The total is now {total}.");
                Console.WriteLine("Would you like to add another number?");
                response = Console.ReadLine();

            }
            while (response.ToLower() == "yes");
            if (response.ToLower() == "no")
            {
                Console.WriteLine("GOODBYE...");
            }
        }
    }
}
