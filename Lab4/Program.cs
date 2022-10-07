using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var legacy = new Legacy();

            legacy.ValueInput(5, 7.2, "qwerty", 'a', true) ;

            Console.ReadLine();
        }
    }
}
