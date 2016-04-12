using System;
using System.Collections.Generic;


namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime? date = new DateTime(2016,02, 13);
            DateTime date2 = date.GetValueOrDefault();

            // Null coalescing operator
            // if date3 is null then set date3 = date else set date3 = datetime.today
            
            DateTime date3 = date ?? DateTime.Today; 

            Console.WriteLine(date2);
            Console.WriteLine(date.GetValueOrDefault());
            Console.WriteLine(date.HasValue);

        }
    }
}
