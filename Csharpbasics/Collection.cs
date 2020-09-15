using System;
using System.Collections.Generic;

namespace LearnCollections{
    public class Collections{
        void LearnLists(){
            List<byte> ages = new List<byte>();
            ages.Add(1);
            ages.Add(8);
            ages.Add(7);
            ages.Add(12);
            ages.Add(54);
            ages.Add(10);

            List<Country> countries = new List<Country>();

            Country country1 = new Country();

            countries.Add(new Country());

        }

        public void LearnDictionary(){
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>();

            countryCapitals.Add("Nepal", "Kathmandu");
            countryCapitals.Add("Australia", "Melbourne");
            countryCapitals.Add("India", "Delhi");

            //DIrect Initialization
            var countryCapitals1 = new Dictionary<string, string>{
                ["Nepal"] = "Kathmandu",
                ["China"] = "Beijing"
            };

            foreach (var country in countryCapitals){
                Console.WriteLine($"Country: {country.Key}  Capital: {country.Value}");
            }
        }
    }

    public class Country{
        public string Name { get; set; }
    }
}