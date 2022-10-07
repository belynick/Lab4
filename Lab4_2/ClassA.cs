using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class ClassA
    {
        List<ClassB> classBs;
        public ClassA(ClassB classB1, ClassB classB2) : this(classB1, classB2, null)
        {

        }

        public ClassA(ClassB classB1, ClassB classB2, ClassB classB3)
        {
            classBs = new List<ClassB>();
            classBs.Add(classB1);
            classBs.Add(classB2);

            if (classB3 != null)
            {
                classBs.Add(classB3);
            }

        }
        public void PrintTree()
        {
            foreach (ClassB classB in classBs)
            {
                classB.ShowMethods();
            }
        }
    }
}
