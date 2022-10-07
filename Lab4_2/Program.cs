using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA classA = new ClassA(new FirstDerived(), new SecondDerived(), new ThirdDerived());
            classA.PrintTree();
        }
    }
}
