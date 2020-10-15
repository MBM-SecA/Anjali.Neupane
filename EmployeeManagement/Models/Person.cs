using System;
using System.Collections.Generic;
public class Person
{
    public int Id { get; set; }
    public string FirstName {get;set;}
    public string SurName{get;set;}
    public string Address{get;set;}
    public char Gender{get;set;}='F';
    public double Salary {get;set;}

    public static List <Person> GetEmployees()
    {
        //Object initializer syntax
        Person empl1 = new Person() {Id=1, FirstName = "Anjali", SurName = "Neupane", Address="Syangja" ,Salary = 2000.0 };
        Person empl2 = new Person() {Id=2, FirstName = "shisam", SurName = "Neupane", Address="Syangja", Salary = 2000.0 };
        Person empl3 = new Person() {Id=3, FirstName = "Shreya", SurName = "Neupane", Address="Syangja" ,Salary = 2000.0 };
        Person empl4 = new Person() {Id=4, FirstName = "Nisha", SurName = "Neupane" ,Address="Syangja" ,Salary = 2000.0 };
        Person empl5 = new Person() {Id=5, FirstName = "Shrisha", SurName = "Neupane" ,Address="Syangja" ,Salary = 2000.0 };
        List <Person> employees =  new List<Person>() { empl1, empl2, empl3, empl4, empl5};
        return employees;
    }
}  