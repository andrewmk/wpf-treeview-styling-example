using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeViewStyleTemplate.Model
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public List<Employee> EmployeeList { get; set; }
    }
}
