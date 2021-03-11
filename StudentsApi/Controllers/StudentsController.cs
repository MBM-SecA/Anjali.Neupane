using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using StudentsApi.Models;
using StudentsApi.Data;
using System.Text.Json;
[Route("students")]
[ApiController]
public class StudentsController: ControllerBase
{
    private StudentContext db;
    public StudentsController(StudentContext _db)
    {
        db = _db;
    }


    [HttpGet]
    [Route("all")]
    public ActionResult GetAllStudents()
    {
        //var students = new string [] {"Sagun","Sandhya"};
        //students = null;
        var students =  db.Students.ToList();
        if (students== null)
        {
            return NotFound();
        }
        return Ok (students);
    }
    [HttpGet]
    [Route("{name}")]
    public ActionResult GetAllStudentsById( string Id)
    {
      // var students = new string [] {"Sagun","Sandhya"};
       // var student = students.Where(x => x== name).FirstOrDefault();
       var student = db.Students.Find(Id);
        if (student == null)
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
        db.Students.Add(student);
        db.SaveChanges();      
        //Add student to db
       // return NoContent(); 
        return Created ("", student);
    }
    [HttpPut]
    [Route("update")]
public ActionResult UpdateStudent(Student student)
{
    if(student == null)
    {
        return BadRequest();
    }    
    db.Students.Attach(student);
    db.Students.Update(student);
    db.SaveChanges();
    return Created("Updated",student);
}
    [HttpDelete]
    [Route("delete")]
public ActionResult RemoveStudent(Student student)
{
    if(student == null)
    {   
        return BadRequest();
    }
    db.Students.Attach(student);
    db.Students.Remove(student);
    db.SaveChanges();
    var result=$"Removed {student.Name} with id={student.Id}";
    return Ok(result);
}
}