using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_2
{
    internal class ThirdDerived : ClassB
    {
        public override int Id()
        {
            id = 3;
            return id;
        }

        public override string Name()
        {
            name = "ThirdDerived";
            return name;
        }

        public override DateTime Date()
        {
            date = DateTime.Now;
            return date;
        }
    }
}
