using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_V04
{
    internal abstract class BasicMaths
    {
        public double Number1 { get; set; }
        public double Number2 { get; set; }

        public virtual void Calculate() { }

    }
}
