using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class ClassB
    {
        protected int id;
        protected string name;
        protected DateTime date;

        public virtual int Id()
            { return id; }

        public virtual string Name()
            { return name; }

        public virtual DateTime Date()
            { return date; }

        public void ShowMethods()
        {
            Console.WriteLine(GetType().Name);
            foreach (var method in GetType().GetMethods())
            {
                Console.WriteLine(method.Name);
            }
            Console.WriteLine();
        }
    }
}
