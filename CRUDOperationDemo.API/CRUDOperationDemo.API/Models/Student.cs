using System.ComponentModel.DataAnnotations;

namespace CRUDOperationDemo.API.Models
{
    public class Student
    {

        public int Id { get; set; }
        [MaxLength(25)]
        public string FirstName { get; set; } = null!;
        [MaxLength(25)]
        public string LastName { get; set; } = null!;
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; } = null!;
        [MaxLength(50)]
        [Phone]
        public string PhonNo { get; set; } = null!;
        [MaxLength(200)]
        public string? Address {  get; set; }
    }
}
