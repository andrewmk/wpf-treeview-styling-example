using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeViewStyleTemplate.Model;

namespace TreeViewStyleTemplate.ViewModel
{
    public class EmployeeViewModel : ViewModelBase
    {
        public Employee Employee { get; protected set; }

        public int EmployeeID
        {
            get { return Employee.EmployeeID; }
            set
            {
                if (Employee.EmployeeID != value)
                {
                    Employee.EmployeeID = value;
                    RaisePropertyChanged(() => EmployeeID);
                }
            }
        }
        public string EmployeeName
        {
            get { return Employee.EmployeeName; }
            set
            {
                if (Employee.EmployeeName != value)
                {
                    Employee.EmployeeName = value;
                    RaisePropertyChanged(() => EmployeeName);
                }
            }
        }
        private bool _isChecked;
        public bool IsChecked
        {
            get { return _isChecked; }
            set
            {
                if (_isChecked != value)
                {
                    _isChecked = value;
                    RaisePropertyChanged(() => IsChecked);
                }
            }
        }
        public EmployeeViewModel(Employee employee)
        {
            this.Employee = employee;
            IsChecked = false;
        }

    }
}
