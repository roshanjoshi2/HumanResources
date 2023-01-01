

using HumanResources.Enums;
using System.ComponentModel.DataAnnotations;

namespace HumanResources.Models
{
    public class Employee
    {
        [Key]
        public int ID {  get; set; }

        public string Name { get; set; }

        public string? Address { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public DateTime? Dob { get; set; }

        public Gender? Gender { get; set; }

        

        public DateTime JoinDate { get; set; }

        public string Department { get; set; }

        public string Designation { get; set; }
    }
}
