using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class SecondDerived : ClassB
    {
        public override int Id()
        {
            id = 2;
            return id;
        }

        public override string Name()
        {
            name = "SecondDerived";
            return name;
        }

        public override DateTime Date()
        {
            date = DateTime.Now;
            return date;
        }
    }
}
