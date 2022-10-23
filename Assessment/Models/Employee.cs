using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Assessment.Models
{
    public class Employee
    {
        
            [Key]
            public int EmployeeId { get; set; }

            [Required(ErrorMessage = "Name Required")]
            [DisplayName("Name")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Email Required")]
            [DisplayName("Email")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Address Required")]
            [DisplayName("Address")]
            public string Address { get; set; }

            [Required(ErrorMessage = "Phone Required")]
            [DisplayName("Phone")]
            
            public int Phone { get; set; }


        }

        public class EmployeeEntities : DbContext
        {
            public DbSet<Employee> employees { get; set; }
        }
    
}
