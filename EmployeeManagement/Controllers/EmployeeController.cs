using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
public class EmployeeController : Controller
{
    public List<Person> employees = Person.GetEmployees();
    public ActionResult Index()
    {
        //var employees = Person.GetEmployees();
        return View(employees);
    }
    public ActionResult Detail (int id)
    {
        var employees = Person.GetEmployees();
        var employee = employees.FirstOrDefault(x => x.Id == id);
        return View(employee);
    }
    
    public ActionResult Add()
    {
        return View();
    } 
    [HttpPost]
    public ActionResult <string> Add(Person person)
    {
        return "Record saved";
    }
}
