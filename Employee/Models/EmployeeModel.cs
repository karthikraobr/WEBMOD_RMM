using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class EmployeeModel
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public string RoomNumber { get; set; }
        public string Manager { get; set; }
    }

    public class DepartmentModel
    {
        public string Name { get; set; }
        public List<string> Members { get; set; }
    }
}