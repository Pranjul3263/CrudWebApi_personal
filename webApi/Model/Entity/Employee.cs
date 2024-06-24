using System.ComponentModel.DataAnnotations;

namespace webApi.Model.Entity
{
    public class Employee
    {
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
