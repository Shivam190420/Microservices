using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        public int eId { get; set; }
        public string eName { get; set; }
        public int salary { get; set; }
    }
}
