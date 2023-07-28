using System.ComponentModel.DataAnnotations;

namespace Practice1.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
    }
}
