using System;
using System.IO;

namespace csPractice4
{
    class ReadTextFile
    {

        public void ReadLineFromFile ()
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Buzz\Desktop\TextFile1.txt");

            Console.WriteLine(text);

            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Buzz\Desktop\TextFile1.txt");
            Console.WriteLine("\n\nContents of text file using a string array/read all lines method");

            foreach(string s in lines)
            {
                Console.WriteLine(s);
            }



        }

        public void WriteLineToFile1()
        {
            string[] lines = { "1", "2", "3" };

            System.IO.File.WriteAllLines(@"C:\Users\Buzz\Desktop\TextFile1.txt", lines);

        }

        public void WriteLineToFile2() 
        {
            string[] lines = new string[3];
            Console.WriteLine("Three favorite hobbies?");

            for(int i = 1; i < 4; i++)
            {
                Console.Write($"{i}.");
                string input = Console.ReadLine();
                lines[i - 1] = input;
            }


            

            System.IO.File.WriteAllLines(@"C:\Users\Buzz\Desktop\TextFile1.txt", lines);
        
        }

        public void WriteLineToFile3()
        {
            string[] lines = { "1 one", "2 two", "3 three" };

            using (StreamWriter file = new StreamWriter(@"C:\Users\Buzz\Desktop\TextFile1.txt"))
            {
                foreach(string s in lines)
                {
                    if(s.Contains("three"))
                    {
                        file.WriteLine(s);
                    }
                }
            }
        }

        public void WriteLineToFile4()
        {
            string[] lines = { "1 one", "2 two", "3 three" };

            using (StreamWriter file = new StreamWriter(@"C:\Users\Buzz\Desktop\TextFile1.txt", true))
            {
                file.WriteLine("Additional line");
            }
        }





    }
}
