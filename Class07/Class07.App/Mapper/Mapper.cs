using Class07.App.Models.Domain;
using Class07.App.Models.ViewModel;

namespace Class07.App.Mapper
{
    public static class Mapper
    {
        public static StudentVM MapToStudentVM(Student student)
        {
            return new StudentVM
            {
                Id = student.Id,
                FullName = student.GetFullName(),
                Age = DateTime.Now.Year - student.DateOfBirth.Year,
                Email = student.Email
            };
        }
    }
}
