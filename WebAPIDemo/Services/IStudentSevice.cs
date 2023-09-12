using WebAPIDemo.Entites;

namespace WebAPIDemo.Services
{
    public interface IStudentSevice
    {
        IEnumerable<Student> GetStudents();
        Student GetStudentById(int id);
        int AddStudent(Student student);
        int UpdateStudent(Student student);
        int DeleteStudent(int id);
    }
}
