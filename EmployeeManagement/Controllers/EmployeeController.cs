using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        //Object initializer syntax
        Person empl1 = new Person() {  FirstName = "Anjali", SurName = "Neupane", Address="Syangja" ,Salary = 2000.0 };
        Person empl2 = new Person() {  FirstName = "shisam", SurName = "Neupane", Address="Syangja", Salary = 2000.0 };
        Person empl3 = new Person() {  FirstName = "Shreya", SurName = "Neupane", Address="Syangja" ,Salary = 2000.0 };
        Person empl4 = new Person() {  FirstName = "Nisha", SurName = "Neupane" ,Address="Syangja" ,Salary = 2000.0 };
        Person empl5 = new Person() {  FirstName = "Anjali", SurName = "Neupane" ,Address="Syangja" ,Salary = 2000.0 };
        List <Person> employees = new List<Person> (){ empl1, empl2, empl3, empl4, empl5};
        return View(employees);
    }
    public ActionResult Detail (string firstName)
    {
        return View();
    }

}
