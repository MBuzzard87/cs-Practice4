using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPractice4
{
    class BMW : Car
    {
        public string Model { get; set; }
        private string brand;
        public BMW(int hp, string color, string model) : base(hp, color)
        {
            brand = "BMW";
            Model = model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("The {0} {1} {2} has {3} HP", Color, brand, Model, HP);
        }

        public sealed override void Repair()
        {
            Console.WriteLine("The {0} {1} was not repaired because it cost too much to fix", brand, Model);
        }
    }
}
