using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeRegistAPI.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID {get;set;}

        [Column(TypeName ="nvarchar(50)")]
        public string EmployeeName {get;set;}

        [Column(TypeName ="nvarchar(50)")]
        public string Occupation {get;set;}
        public string ImageName {get;set;}
    }
}