using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csPractice4
{
    class DateTimeT
    {
        

        public DateTimeT()
        {

            DateTime dateTime = new DateTime(1987, 2, 7);

            Console.WriteLine("My birthday is {0}", dateTime);


            // Current date and time
            Console.WriteLine(DateTime.Today.DayOfWeek);
            Console.WriteLine(DateTime.Now);

            Console.WriteLine(GetTomorrow().DayOfWeek);
            Console.WriteLine(GetTomorrow());

            Console.WriteLine(GetFirstDayOfYear(1999).DayOfWeek);


            DateTime now = DateTime.Now;
            Console.WriteLine("The time is {0}:{1}:{2}", now.Hour, now.Minute, now.Second);


            Console.WriteLine("Write a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine("Days passed since: {0}", daysPassed.Days);
            }

        }

        public DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        public DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }

    }
}
