using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPractice4
{

    struct Game
    {
        public string name;
        public string developer;
        public double rating;
    }

    enum Day { Mon,Tues,Wed,Thu,Fri,Sat,Sun};
    enum Month { Jan = 1, Feb, Mar, Apr, May,Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec};

    class Program
    {
        static void Main(string[] args)
        {
            /* Classes:  Audi, BMW, Cars, M3
             * 
             * 
             * 
            var cars = new List<Car>
            {
                new Audi(300,"Silver", "A8"),
                new BMW(330, "Black", "M3")
            };

            foreach(var car in cars)
            {
                car.ShowDetails();
                car.Repair();
            }

            
            Console.WriteLine("\n\n");
            Car bmw = new BMW(200, "Black", "Z3");
            Console.WriteLine("Car type show details");
            bmw.ShowDetails();
            
            Console.WriteLine("\nBMW type show details");
            BMW z3 = (BMW)bmw;
            z3.ShowDetails();
            Console.WriteLine("\n\n");
            z3.SetCarIDInfo(1234, "Buzz");
            z3.GetCarIDInfo();
            */

            /*
            Console.WriteLine("\n\n");
            M3 myM3 = new M3(260, "Red", "M3");
            myM3.Repair();

            myM3.SetCarIDInfo(1234, "Buzz");
            myM3.GetCarIDInfo();
            */

            /*
            Cube cube = new Cube(10);
            Console.WriteLine(cube.Volume());
            cube.GetInfo();
            */


            /* Shape - Cube - Sphere
            Shape[] shapes = { new Sphere(4), new Cube(5) };

            foreach(Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Volume());

                Cube iceCube = s as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is not a cube");
                }

                if(s is Cube)
                {
                    Console.WriteLine("This shape is a cube");
                }

                

            }

            object cube1 = new Cube(7);
            Cube cube2 = (Cube)cube1;

            Console.WriteLine("\n\n{0} has a Volume of {1}", cube2.Name, cube2.Volume());
            */

            /* ReadTextFile
            ReadTextFile read = new ReadTextFile();
            //basic file read/write
            read.WriteLineToFile1();
            read.ReadLineFromFile();
            Console.WriteLine("\n\n");

            //read/write based on input
            read.WriteLineToFile2();
            read.ReadLineFromFile();
            Console.WriteLine("\n\n");

            //read/write using streamwriter and a conditional
            read.WriteLineToFile3();
            read.ReadLineFromFile();
            Console.WriteLine("\n\n");

            //add an additional line to the file with streamwriter
            read.WriteLineToFile4();
            read.ReadLineFromFile();

            */

            /* Game Struct ^^^^^^
            Game game1;

            game1.name = "Super Castlevania IV";
            game1.developer = "Konami";
            game1.rating = 9.5;
            
            */

            /* enum ^^^^^
            Day fr = Day.Fri;
            Day su = Day.Sun;
            Day a = Day.Fri;

            Console.WriteLine(a == fr);
            Console.WriteLine(Day.Mon);
            Console.WriteLine((int)Day.Mon);

            Console.WriteLine((int)Month.Aug);
            Console.WriteLine((int)Month.Jun);

            */

            
            RandomFortune ranfortune = new RandomFortune();
            
            Console.ReadKey();
            
        }
    }
}
