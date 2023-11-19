using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Abstract_cals
{
    internal class Apple:Fruit
    {
        public int VitaminA { get; set; }
        public int VitaminB { get;set; }

        public override void Dad()
        {
            Console.WriteLine("Wirin dadi var");
        }
    }
}
