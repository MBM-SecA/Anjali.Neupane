using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using StudentApi.Models;
using System.Text.Json;
[Route("students")]
[ApiController]
public class StudentsController: ControllerBase
{
    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        var students = new string [] {"Sagun","Sandhya"};
        students = null;
        if (students== null)
        {
            return NotFound();
        }
        return Ok (students);
    }
    [HttpGet]
    [Route("{name}")]
    public ActionResult GetAllStudentsById( string name)
    {
       var students = new string [] {"Sagun","Sandhya"};
        var student = students.Where(x => x== name).FirstOrDefault();
        if (students == null)
        {
            return NotFound();
        }
        return Ok (student); 
    }
     [HttpPost]
    [Route("add")]
    public ActionResult CreateStudent ( Student student)
    {
        if (student == null)
        {
            return BadRequest();
        }
        //Add student to db
       // return NoContent(); 
       return Created ("", student);
    }
    private void FirstOrDefault()
    {
        throw new NotImplementedException();
    }
}