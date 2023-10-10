using BlazorServerApp.Context;
using BlazorServerApp.Data;

namespace BlazorServerApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly ApplicationDbContext _dbContext;
        public StudentService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string Delete(int studentId)
        {
            var student = _dbContext.Students.FirstOrDefault(x => x.StudentId == studentId);
            if(student is not null)
            {
                _dbContext.Students.Remove(student);
                _dbContext.SaveChanges();
            }

            return "Deleted";
        }

        public Student GetById(int studentId)
        {
            var students = _dbContext.Students.SingleOrDefault(x => x.StudentId == studentId);

            return students;
        }

        public List<Student> GetStudents()
        {
            return _dbContext.Students.ToList();
        }

        public void Save(Student student)
        {
            if(student.StudentId == 0)
            {
                _dbContext.Students.Add(student);
            }
            else
            {
                _dbContext.Students.Update(student);
            }                
            _dbContext.SaveChanges();
        }
    }
}
