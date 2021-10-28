using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPractice4
{
    class Audi : Car
    {

        public string Model { get; set; }
        private string brand;
        public Audi(int hp, string color, string model) : base(hp,color)
        {
            brand = "Audi";
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("The {0} {1} {2} has {3} HP", Color, brand, Model, HP);
        }

        public override void Repair()
        {
            Console.WriteLine("The {0} has been repaired", brand);
        }

    }
}
