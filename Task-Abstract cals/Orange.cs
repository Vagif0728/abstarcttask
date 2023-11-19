using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Abstract_cals
{
    internal class Orange : Fruit
    {
        public int VitaminC { get; set; }

        public override void Dad()
        {
            Console.WriteLine("Turw dadi var");
        }
    }
}
