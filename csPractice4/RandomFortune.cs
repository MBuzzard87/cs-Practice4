using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPractice4
{
    class RandomFortune
    {

        public RandomFortune()
        {
            Console.WriteLine("Ask a question and you shall receive your fortune");
            Console.ReadLine();

            Random numRan = new Random();
            string[] fortune = { "Yes", "No", "Maybe" };

            Console.WriteLine(fortune[numRan.Next(0, 3)]);

            

        }


    }
}
