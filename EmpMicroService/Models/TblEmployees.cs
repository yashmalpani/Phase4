using System;
using System.Collections.Generic;

namespace EmpMicroService.Models
{
    public partial class TblEmployees
    {
        public int EmplyeeId { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public int? EmpSalary { get; set; }
    }
}
