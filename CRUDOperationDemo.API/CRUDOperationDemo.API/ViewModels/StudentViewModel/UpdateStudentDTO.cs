namespace CRUDOperationDemo.API.ViewModels.StudentViewModel
{
    public class UpdateStudentDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string PhonNo { get; set; } = null!;
        public string? Address { get; set; }
    }
}
