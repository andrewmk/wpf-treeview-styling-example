using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using TreeViewStyleTemplate.Model;

namespace TreeViewStyleTemplate.ViewModel
{
    public class CompanyDetailViewModel : ViewModelBase
    {
        private ObservableCollection<DepartmentViewModel> _departmentCollection;
        public ObservableCollection<DepartmentViewModel> DepartmentCollection
        {
            get { return _departmentCollection; }
            set
            {
                if (_departmentCollection != value)
                {
                    _departmentCollection = value;
                    RaisePropertyChanged(() => DepartmentCollection);
                }
            }
        }
        public CompanyDetailViewModel()
        {
            DepartmentCollection = new ObservableCollection<DepartmentViewModel>();
            List<Department> departmentList = GetDepartmentList();
            foreach (Department department in departmentList)
            {
                DepartmentCollection.Add(new DepartmentViewModel(department));
            }
        }

        #region Methods
        List<Employee> GetEmployeeList()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { EmployeeID = 1, EmployeeName = "Hiren" });
            employeeList.Add(new Employee() { EmployeeID = 2, EmployeeName = "Imran" });
            employeeList.Add(new Employee() { EmployeeID = 3, EmployeeName = "Shivpal" });
            employeeList.Add(new Employee() { EmployeeID = 4, EmployeeName = "Prabhat" });
            employeeList.Add(new Employee() { EmployeeID = 5, EmployeeName = "Sandip" });
            employeeList.Add(new Employee() { EmployeeID = 6, EmployeeName = "Chetan" });
            employeeList.Add(new Employee() { EmployeeID = 7, EmployeeName = "Jayesh" });
            employeeList.Add(new Employee() { EmployeeID = 8, EmployeeName = "Bhavik" });
            employeeList.Add(new Employee() { EmployeeID = 9, EmployeeName = "Amit" });
            employeeList.Add(new Employee() { EmployeeID = 10, EmployeeName = "Brijesh" });
            return employeeList;
        }
        List<Department> GetDepartmentList()
        {
            List<Employee> employeeList = GetEmployeeList();
            List<Department> departmentList = new List<Department>();
            departmentList.Add(new Department() { DepartmentID = 1, DepartmentName = "Mocrosoft.Net", EmployeeList = employeeList.Take(3).ToList() });
            departmentList.Add(new Department() { DepartmentID = 2, DepartmentName = "Open Source", EmployeeList = employeeList.Skip(3).Take(3).ToList() });
            departmentList.Add(new Department() { DepartmentID = 3, DepartmentName = "Other", EmployeeList = employeeList.Skip(6).Take(4).ToList() });
            return departmentList;
        }
        #endregion
    }
}
