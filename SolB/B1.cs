using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolB
{
    class B1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a double:  ");
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            Console.WriteLine("{0:0.###}",Math.Sqrt(x));
        }
    }
}
