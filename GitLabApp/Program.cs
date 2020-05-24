using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLabApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double x = Convert.ToDouble(s);
            double F = 8 * Math.Sin(2*x)-Math.Cos(2*x);
            Console.WriteLine(F);
            Console.ReadKey();

              
        }
    }
}
