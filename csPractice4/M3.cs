using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPractice4
{
    class M3 : BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model)
        {

        }

        /*  Method is sealed within BMW class so it can not be overridden
          
        public override void Repair()
        {
            base.Repair();
        }
        */
    }
}
