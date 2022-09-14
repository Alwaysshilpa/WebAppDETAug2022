using ODatademo.Models;

namespace ODatademo.Service
{
    public interface IStudentService
    {
        IQueryable<Student> RetrieveAllStudents();
    }
}
