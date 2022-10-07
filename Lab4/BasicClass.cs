using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_1
{
    internal class BasicClass
    {
        public virtual void ValueInput(params object[] values)
        {
            foreach (object type in values)
            {
                Debug.Print($"{type.GetType()} - {type}");
            }
        }
    }
}
