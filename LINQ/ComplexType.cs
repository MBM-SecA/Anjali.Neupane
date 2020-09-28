using System;
using System.Linq;
public class ComplexType
{
    public void LearnLINQ()
    {
       // Program for countries
            var countries = Country.GetCountries();

            var asianCountries = from country in countries
                                 where country.Continent == "Asia"
                                 select country.Name;
            // foreach (var country in asianCountries)
            // {
            //     Console.WriteLine(country);
            // }

            // Q1: Countries in EUROPE which has population less than 100k
             var europeCountries = from country in countries
                                   where country.Continent == "Europe" && country.Population < 100000
                                   select country.Name;                     

            foreach(var country in europeCountries)
            {
                Console.WriteLine(country);
            }
            // Q2: Countries in ASIA which are never invaded.
            var asianCountries1 = from country in countries
                                  where country.Continent == "Asia" && country.IndependenceDay == default
                                  select country.Name;
            
            foreach(var country in asianCountries1)
            {
                Console.WriteLine(country);
            }
            // Q3: Is there any African country in  country collection
            var africanCountries= countries.Any (x=> x.Continent=="Africa");
            if(africanCountries)
            {
                Console.WriteLine("There are African Countries.");
            }
            else
            {
                Console.WriteLine("There are NO African Countries.");
            }
            // Q4: Print first two largest Asian country names
            var largest = countries.OrderByDescending (asianCountries => asianCountries.Area);
            Console.WriteLine("Two largest Asian countries are:");
            
            foreach (var country  in largest.Take(2))
            {
                Console.WriteLine(country.Name);
            }
            

    }
}