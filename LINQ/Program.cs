using System;
using System.Linq;
using System.Collections.Generic;
namespace LINQ
{
    class Program
    {

        static void Main()
        {
            // LINQ - Language Integrated Query
            // LINQ to objects

            int[] numbers = { 15, 23, 87, 43, 47, 90, 10, 35, 55, 79, 34, 78, 45, 70 };

            // Fetch numbers which are greater than 50 and less than 70

            // Using method syntax - lambda expression
            var result1 = numbers.Where(x => x > 50 && x < 70);

            // Using sql query syntax - Query expression
            var result2 = from num in numbers
                          where num > 50 && num < 70
                          select num;


            string[] names = { "shreya", "sisam", "hari", "ramesh", "ram", "sita", "rahul" };

            // Names having length greater than 3 and starts with letter 'R'
            var result3 = names.Where(x => x.Length > 3 && x.ToUpper().StartsWith("R"));

            var result4 = from name in names
                          where name.Length > 3 && name.ToLower().StartsWith("r")
                          select name;


            // foreach (var name in result4)
            // {
            //     Console.WriteLine(name);
            // }
            //Projections
            //var result5 = numbers.Select (x=> x*x);
            var result5 = from num in numbers
                            select num* num;
            foreach(var square in result5)
            {
                Console.WriteLine(square);
            }
            //Ordering
            var result6 = from num in numbers
                            orderby num 
                            select num;
            //Partitioning
            var result7 = numbers.Skip(5).Take(5); 
            //Quantifier
            var result8 = numbers.Any (x => x%2 == 0);
            var result9 = numbers.All (x => x%2 == 0);
            var result10 =numbers.Contains(34);
            var result11 = Enumerable.Range(1,1000);
            var result12 = Enumerable.Repeat("Hello World!", 10);
             foreach(var square in result6)
            {
                Console.WriteLine(square);
            }
            foreach(var num in result7)
            {
                Console.WriteLine(num);
            }
            foreach(var num in result12)
            {
                Console.WriteLine(num);
            } 
            ComplexType complexType = new ComplexType();
            complexType.LearnLINQ();
        }        
    }
       
}