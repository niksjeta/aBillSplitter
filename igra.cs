using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 
namespace BillSplitter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! Welcome to the bill splitter! ");

            Console.WriteLine("\nThe total amount of the bill is?");
            double total = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nHow many people have attented?");
            int people = Convert.ToInt32(Console.ReadLine());

            double TotalPerPerson = (double)total / people;

            Console.WriteLine($"\nYour total is {TotalPerPerson}, Would you also like to include the tip?");
            string odgovor = Console.ReadLine(); //yes or no

            if (odgovor == "yes")
            {
                Console.WriteLine("\nWhich percentage are you choosing to tip? 12, 16 or 20?");
                int percent = Convert.ToInt32(Console.ReadLine());
                double finalPercent = ((double)(percent * TotalPerPerson / 100));
                double finalTip = (finalPercent + TotalPerPerson);

                Console.WriteLine($"\nThe total of the bill with the added tip is: {finalTip}");
                
            }
            else {
                Console.WriteLine(":(");
            }
            
            Console.ReadKey();
        }
    }
}
