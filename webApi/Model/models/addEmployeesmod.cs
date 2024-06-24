using System.ComponentModel.DataAnnotations;

namespace webApi.Model.models
{
    public class addEmployeesmod
    {
        public string? Name { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public decimal Salary { get; set; }
    }
}
