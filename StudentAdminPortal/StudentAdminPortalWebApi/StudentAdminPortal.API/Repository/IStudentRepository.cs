using StudentAdminPortal.API.Models;

namespace StudentAdminPortal.API.Repository
{
    public interface IStudentRepository
    {
       Task<List<Student>> GetStudentsAsync();
    }
}
