using WebAPIDemo.Entites;
using WebAPIDemo.Repositories;

namespace WebAPIDemo.Services
{
    public class StudentService : IStudentSevice
    {
        private readonly IStudentRepository repo;
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;
        }
        public int AddStudent(Student student)
        {
            return repo.AddStudent(student);
        }

        public int DeleteStudent(int id)
        {
            return repo.DeleteStudent(id);
        }

        public Student GetStudentById(int id)
        {
            return repo.GetStudentById(id);
        }

        public IEnumerable<Student> GetStudents()
        {
            return repo.GetStudents();
        }

        public int UpdateStudent(Student student)
        {
            return repo.UpdateStudent(student);
        }
    }
}
