using StudentMgmtSystem.Entities;
using StudentMgmtSystem.Services;
namespace StudentMgmtSystem.Services
{
    public interface IStudentService
    {
       public List<Student> GetStudents();
      //  bool insert_service(Student student);

       // bool delete_service(int id);

      //  bool update_service(Student student);
    }
}
