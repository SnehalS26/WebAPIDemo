using WebAPIDemo.Entites;

namespace WebAPIDemo.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext context;
        public StudentRepository(ApplicationDbContext context)
        {

            this.context = context;

        }

        public int AddStudent(Student student)
        {
            int result = 0;
            student.IsActive = 1;
            context.Students.Add(student);
            result = context.SaveChanges();
            return result;
        }

        public int DeleteStudent(int id)
        {
            int result = 0;
            var stud = context.Students.Where(x => x.Roll == id).FirstOrDefault();
            if (stud != null)
            {
                stud.IsActive = 0;
                result = context.SaveChanges();
            }
            return result;
        }

        public Student GetStudentById(int id)
        {
            int result = 0;
            var stud = context.Students.Where(x => x.Roll == id).FirstOrDefault();
            return stud;
        }

        public IEnumerable<Student> GetStudents()
        {
            return context.Students.Where(x => x.IsActive == 1).ToList();
        }

        public int UpdateStudent(Student student)
        {
            int result = 0;
            var s = context.Students.Where(x => x.Roll == student.Roll).FirstOrDefault();
            if (s != null)
            {
                s.Roll = student.Roll;
                s.Name = student.Name;
               s.Percentage = student.Percentage;
                s.IsActive = 1;
                result = context.SaveChanges();
            }
            return result;
        }
    }
}
