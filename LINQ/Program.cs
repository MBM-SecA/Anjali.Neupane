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

            // Using nethod syntax - lambda expression
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


            // Program for countries
            var countries = Country.GetCountries();

            var asianCountries = from country in countries
                                 where country.Continent == "Asia"
                                 select country.Name;
            // foreach (var country in asianCountries)
            // {
            //     Console.WriteLine(country);
            // }



            // Q1: List countries in EUROPE which has population less than 100k
             var europeCountries = from country in countries
                                   where country.Continent == "Europe" && country.Population < 100000
                                   select country.Name;                     

            foreach(var country in europeCountries)
            {
                Console.WriteLine(country);
            }
            // Q2: List countries in ASIA which are never invaded.
            var asianCountries1 = from country in countries
                                  where country.Continent == "Asia" && country.IndependenceDay == default
                                  select country.Name;
            
            foreach(var country in asianCountries1)
            {
                Console.WriteLine(country);
            }

        }
    }
}