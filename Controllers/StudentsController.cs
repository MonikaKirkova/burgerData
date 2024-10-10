using BurgersData.Models;
using Microsoft.AspNetCore.Mvc;

namespace BurgersData.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    //public class StudentsController : ControllerBase
    //{
    //    public static List<Student> students = new()
    //    {
    //        new Student { Id=1, FirstName="Tom", LastName="Starlen", Age=17, City= "Negambo"},
    //        new Student { Id=2, FirstName="Ann", LastName="Mary", Age=15, City= "Colombo"},
    //        new Student { Id=3, FirstName="Peter", LastName="Silva", Age=17, City= "Mount-Lavinea"}
    //    };

    //    [HttpGet]
    //    public IActionResult GetAllStudents()
    //    {
    //        return Ok(students);
    //    }

    //    [HttpGet("{id}")]
    //    public IActionResult GetStudent(int id)
    //    {
    //        var student = students.Find(x => x.Id == id);
    //        if (student == null)
    //        {
    //            return NotFound("Student not found");
    //        }
    //        return Ok(student);
    //    }

    //    [HttpPost]
    //    public IActionResult CreateStudent(Student student)
    //    {
    //        students.Add(student);
    //        return Ok(student);
    //    }

    //    [HttpPut]
    //    public IActionResult UpdateStudent(Student student)
    //    {
    //        var studentInList = students.Find(x => x.Id == student.Id);
    //        if (student == null)
    //        {
    //            return NotFound("Invalid student details");
    //        }
    //        studentInList.FirstName = student.FirstName;
    //        studentInList.LastName = student.LastName;
    //        studentInList.Age = student.Age;
    //        studentInList.City = student.City;
    //        return Ok(studentInList);
    //    }

    //    [HttpDelete]
    //    public IActionResult DeleteStudent(int id)
    //    {
    //        var student = students.Find(x => x.Id == id);
    //        if (student == null)
    //        {
    //            return NotFound("Invalid student details");
    //        }
    //        students.Remove(student);
    //        return Ok(students);
    //    }

    //}
}

