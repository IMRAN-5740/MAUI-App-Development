using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CRUDOperationDemo.API.Models
{
    public class Users:IdentityUser
    {

       
        [MaxLength(25)]
        public string FirstName { get; set; } = null!;
        [MaxLength(25)]
        public string LastName { get; set; } = null!;
        [MaxLength(6)]
        public string Gender {  get; set; } = null!;
        [MaxLength(200)]
        public string? Address { get; set; }
    }
}
