using System;


namespace csPractice4
{
    class RandomFortune
    {

        public RandomFortune()
        {
            Console.WriteLine("Ask a question and you shall receive your fortune");
            Console.ReadLine();

            Random answerNum = new Random();
            string[] fortune = { "Yes", "No", "Maybe" };

            Console.WriteLine(fortune[answerNum.Next(0, 3)]);

            

        }


    }
}
