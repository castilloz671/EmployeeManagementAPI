using System.ComponentModel.DataAnnotations;

namespace EmployeeManagementAPI.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string Phone { get; set; }

        [StringLength(100)]
        public string Address { get; set; }

        [StringLength(50)]
        public string Position { get; set; }

        [StringLength(50)]
        public string Office { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        public decimal CalculateNetSalary()
        {
            decimal ARS = Salary * 0.0304M;
            decimal AFP = Salary * 0.0287M;
            return Salary - ARS - AFP;
        }
    }
}
