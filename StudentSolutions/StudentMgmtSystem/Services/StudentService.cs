using StudentMgmtSystem.Services;
using StudentMgmtSystem.Repositories;
using StudentMgmtSystem.Entities;
namespace StudentMgmtSystem.Services
{
    public class StudentService:IStudentService
    {
        public List<Student> GetStudents()
        {
            IstudentRepo studentRepo = new StudentRepo();
             return studentRepo.GetStudents();
        }
      
    }
}
