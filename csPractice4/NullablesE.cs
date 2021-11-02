using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPractice4
{
    class NullablesE
    {

        

        public NullablesE()
        {
            // Add "?" after int for an integer to be nullable
            int? num1 = null;


            //Cannot assign null to an integer
            // int num2 = null;

            int? num2 = 1999;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolVal = new bool?();

            Console.WriteLine($"{num1}, {num2}, {num3}, {num4}");
            Console.WriteLine(boolVal);

            double? num5 = 13.5;
            double? num6 = null;
            double num7;

            if(num5 == null)
            {
                num7 = 0.0;
            } 
            else
            {
                num7 = (double)num5;
            }

            Console.WriteLine(num7);



            // Null Coalescing Operator
            num7 = num5 ?? 8.5;
            Console.WriteLine(num7);
            num7 = num6 ?? 8.5;
            Console.WriteLine(num7);


        }


    }
}
