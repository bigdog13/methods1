using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randomstringreplacement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a day of the week");
            string day = Console.ReadLine();
            day = day.Replace("O", "");

            if (day != "O")
            {
                Console.WriteLine("This string is okay");
            }
                

        }
    }
}
