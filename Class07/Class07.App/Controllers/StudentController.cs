using Class07.App.Database;
using Class07.App.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;



namespace Class07.App.Controllers
{
    [Route("students")]
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            List<StudentVM> students = StaticDb.Students.Select(x => 
            Class07.App.Mapper.Mapper.MapToStudentVM(x)).ToList();

            return View(students);
        }
    }
}
