using Avenga.ASP.NET.MVC.Class03.DataAccess;
using Avenga.ASP.NET.MVC.Class03.Models.Domains;

namespace Avenga.ASP.NET.MVC.Class03.Services
{
    public class StudentService
    {
        public Student GetStudentWithActiveCourse(int id)
        {
            var student = InMemoryDb.Students.FirstOrDefault(x => x.Id == id);

            if (student == null)
            {
                return null;
            }

            return student;
        }
    }
}
