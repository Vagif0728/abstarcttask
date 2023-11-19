using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Abstract_cals
{
    internal class Pineapple:Fruit
    {
        public int VitaminE { get; set; }

        public int VitaminD { get; set; }

        public override void Dad()
        {
            Console.WriteLine("Turw meze dadi var");
        }
    }
}
