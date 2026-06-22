using Class02.Controllers.Models;
using Microsoft.AspNetCore.Mvc;

namespace Class02.Controllers.Controllers;

public class CoursesController : Controller
{

    private List<Course> _courses = new List<Course>()
    {
        new Course {Id = 1, Name = "C# Basic", NumberOfClasses = 10},
        new Course {Id = 2, Name = "JavaScript", NumberOfClasses = 12},
        new Course {Id = 3, Name = "MVC.NET", NumberOfClasses = 14},
    };

    // default HTTPGET method
    public IActionResult GetAllCourses()
    {
        return Json(_courses);
    }

    public IActionResult GetCourseById(int id) // localhost:port/courses/getCoursesById/10
    {
        return Json(_courses.FirstOrDefault(x => x.Id == id));
    }

    public JsonResult GetCourseByName(string name) // localhost:port/
    {
        return Json(_courses.FirstOrDefault(x => x.Name == name)); 
    }
}
