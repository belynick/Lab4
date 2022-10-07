using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class FirstDerived : ClassB
    {
        public override int Id()
        {
            id = 1;
            return id;
        }

        public override string Name()
        {
            name = "FirstDerived";
            return name;
        }

        public override DateTime Date()
        {
            date = DateTime.Now;
            return date;
        }
    }
}
