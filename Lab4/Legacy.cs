using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class Legacy : BasicClass
    {
        Random random;

        public Legacy()
        {
            random = new Random();
        }

        public override void ValueInput(params object[] values)
        {
            foreach (object obj in values)
            {
                Console.ForegroundColor = (ConsoleColor)random.Next(1, 16);
                Console.WriteLine($"{obj.GetType()} - {obj}");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
