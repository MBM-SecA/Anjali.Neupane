using System;
using System.Collections.Generic;

public class Country
{
    public string Name { get; set;}
    public string Continent { get; set;}
    public double Area { get; set;}
    public long Population { get; set;}
    public DateTime IndependenceDay { get; set;}
    public string Independence { get; internal set; }

    public Country( string n, string c, double a, long p, DateTime i= default)
    {
        Name = n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
    }

    public static List<Country> GetCountries()
    {
        Country c1 = new Country( "Nepal", "Asia", 2345, 348985);
        Country c2 = new Country( "India", "Asia", 2356445, 3287679,DateTime.Parse("1947/01/01"));
        Country c3 = new Country( "China", "Asia", 2459850, 948347377);
        Country c4 = new Country( "UK", "Europe", 34456545,678899);
        Country c5 = new Country( "UK", "Europe", 34456545,678899);
        Country c6 = new Country( "USA", "North America", 4576478, 569853);
        Country c7 = new Country( "Portugal", "Europe", 234556, 359809);
        Country c8 = new Country( "Pakistan", "Asia", 67342, 5326784);
        Country c9 = new Country( "Argentina", "South America", 2636246764, 453276);
        Country c10 = new Country( "Canada", "North America", 615652.34, 3456545);
        Country c11 = new Country( "Austria", "Europe", 2345, 2235);
        Country c12 = new Country("Germany", "Europe", 87345345, 98273);
        Country c13 = new Country( "Peru", "South America", 6354653.34, 3456545);
        Country c14 = new Country( "Uruguay", "South America", 732648732.34, 3456545);
        Country c15 = new Country( "Brazil", "South America", 3632476.34, 3456545);
        Country c16 = new Country( "Austria", "Europe", 32764, 34565);
        Country c17 = new Country("England", "Europe", 34899,54682 );
        Country c18 = new Country("France", "Europe", 28482, 54682);
        Country c19 = new Country("Italy", "Europe", 4674, 54682 );
        Country c20 = new Country("Spain", "Europe", 37469, 948434 );
        
        var countries = new List<Country>() {c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20 };

        return countries;
    }
} 