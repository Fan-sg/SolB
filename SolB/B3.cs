using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B3
    {
        static void Main()
        {
            Console.WriteLine("Enter the salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());
            double total_income = salary + salary * 0.13;
            Console.WriteLine("Total output is ${0:0,0.00}", total_income);
        }
    }
}
