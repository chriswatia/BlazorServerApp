using BlazorServerApp.Data;
using Microsoft.AspNetCore.Mvc;

namespace BlazorServerApp.Services
{
    public interface IStudentService
    {
        List<Student> GetStudents();
        Student GetById(int studentId);
        void Save(Student student);
        string Delete(int studentId);
    }
}
