﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPractice4
{
    class Car
    {

        public int HP { get; set; }
        public string Color { get; set; }

        public Car(int hp, string color)
        {
            HP = hp;
            Color = color;
        }

        public Car()
        {
           
        }

        public void ShowDetails()
        {
            Console.WriteLine("HP: {0}\nColor: {1}", HP, Color);
        }

        public virtual void Repair()
        {
            Console.WriteLine("The car has been repaired");
        }

    }
}
