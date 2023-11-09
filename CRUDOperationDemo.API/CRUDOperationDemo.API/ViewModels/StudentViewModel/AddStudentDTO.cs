using System.ComponentModel.DataAnnotations;

namespace CRUDOperationDemo.API.ViewModels.StudentViewModel
{
    public class AddStudentDTO
    {

        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string PhonNo { get; set; } = null!;
        public string? Address { get; set; }
    }

}
