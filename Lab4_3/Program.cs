using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sword sword = new Sword();
            sword.PrintProperties();

            Spear spear = new Spear();
            spear.PrintProperties();

            Halberd halberd = new Halberd();
            halberd.PrintProperties();

            Console.ReadLine();
        }
    }
}
