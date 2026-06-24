using Avenga.ASP.NET.MVC.Class03.DataAccess;
using Avenga.ASP.NET.MVC.Class03.Models.Domains;
using Avenga.ASP.NET.MVC.Class03.Models.DTOs;

namespace Avenga.ASP.NET.MVC.Class03.Services;

public class StudentService : StudentWithCourseDto
{
    //public Student GetStudentWithActiveCourse(int id)
    //{
       // var student = InMemoryDb.Students.FirstOrDefault(x => x.Id == id);

       // if (student == null)
        //{
          //  return null;
        //}

   //}

    public StudentWithCourseDto GetStudentWithActiveCourse(int id)
    {
        var student = InMemoryDb.Students.FirstOrDefault(x => x.Id == id);
        if (student == null)
        {
            return null;
        }

        
        var studentDto = new StudentWithCourseDto();
        {
           
                
        }

        return student;
        
    }
}

