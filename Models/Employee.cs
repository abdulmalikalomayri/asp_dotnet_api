using System;
using System.Collections.Generic;

namespace CrudApp.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int? Salary { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
