using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreMVCEntityFramework.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FullName{ get; set; }
        public string EmpCode{ get; set; }
        public string Position{ get; set; }
        public string OfficeLocation{ get; set; }
    }
}
