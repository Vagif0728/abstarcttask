using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Abstract_cals
{
    internal abstract class Fruit
    {
        public double Price { get; set; }

        public string Sort { get; set; }

        public abstract void Dad();
    }
}
