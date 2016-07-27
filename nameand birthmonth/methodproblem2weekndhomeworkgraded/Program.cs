using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodproblem2weekndhomeworkgraded
{
    class Program
    {
        static void Main(string[] args)
            //input par users name
        {
            Console.WriteLine("What is your name?");
                string name = Console.ReadLine();
            // user month born
            Console.WriteLine("What month were you born?");
            string month = Console.ReadLine();
            Console.Clear();
            //month op was an born
            if (month == "April" || month == "August" || month == "October")

            {
                Console.WriteLine("{0} is an {1} baby!", name, month);
            }
            //month born a
            else if (month == "January" || month == "February"|| month == "March" || month == "May" || month =="June" || month =="July" || month =="September" || month =="November" || month == "December")

            {//result
                Console.WriteLine("{0} is a {1} baby!", name, month);
            }
            

        }
    }
}
