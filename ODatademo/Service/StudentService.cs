using ODatademo.Models;

namespace ODatademo.Service
{
    public class StudentService : IStudentService
    {
        public IQueryable<Student> RetrieveAllStudent()
        {
            return new List<Student>
            {
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "shilpa",
                    Score = 200
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "sirisha",
                    Score = 160
                },
                new Student
                {
                    Id = Guid.NewGuid(),
                    Name = "swapana",
                    Score = 170
                },

            }.AsQueryable();
        }

        public IQueryable<Student> RetrieveAllStudents()
        {
            throw new NotImplementedException();
        }
    }
}


       