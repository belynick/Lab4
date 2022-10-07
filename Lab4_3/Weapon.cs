using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_3
{
    internal class Weapon
    {
        public int Durability { get; set; }
        public int Damage { get; set; }
        public void PrintProperties()
        {
            Console.WriteLine(GetType().Name);
            foreach (var propertyInfo in GetType().GetProperties())
            {
                Console.WriteLine($"{propertyInfo.PropertyType} {propertyInfo.Name}");
            }
            Console.WriteLine();
        }
    }
}
