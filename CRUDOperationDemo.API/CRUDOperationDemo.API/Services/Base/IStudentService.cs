using CRUDOperationDemo.API.Models;
using CRUDOperationDemo.API.Responces;
using CRUDOperationDemo.API.ViewModels;
using System.Linq.Expressions;

namespace CRUDOperationDemo.API.Services.Base
{
    public interface IStudentService
    {
        Task<MainResponse> AddStudent(AddStudentDTO entity);
        Task<MainResponse> UpdateStudent(UpdateStudentDTO entity);
        Task<MainResponse> DeleteStudent(DeleteStudentDTO entity);
        Task<MainResponse> GetAllStudent(Expression<Func<Student, bool>>? predicate = null);
        Task<MainResponse> GetStudentById(Expression<Func<Student, bool>>? predicate=null);
       
    }
}
