using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TreeViewStyleTemplate.Model;
using System.Collections.ObjectModel;

namespace TreeViewStyleTemplate.ViewModel
{
    public class DepartmentViewModel:ViewModelBase
    {
        public Department Department { get; protected set; }

        private ObservableCollection<EmployeeViewModel> _employeeCollection;
        public ObservableCollection<EmployeeViewModel> EmployeeCollection
        {
            get { return _employeeCollection; }
            set {
                if (_employeeCollection != value)
                {
                    _employeeCollection = value;
                    RaisePropertyChanged(() => EmployeeCollection);
                }
            }
        }
        public int DepartmentID
        {
            get { return Department.DepartmentID; }
            set {
                if (Department.DepartmentID != value)
                {
                    Department.DepartmentID = value;
                    RaisePropertyChanged(() => DepartmentID);
                }
            }
        }
        public string DepartmentName
        {
            get { return Department.DepartmentName; }
            set {
                if (Department.DepartmentName != value)
                {
                    Department.DepartmentName = value;
                    RaisePropertyChanged(() => DepartmentName);
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
                    OnCheckChanged();
                }
            }
        }
        private void OnCheckChanged()
        {
            foreach (EmployeeViewModel employeeViewModel in EmployeeCollection)
            {
                employeeViewModel.IsChecked = IsChecked;
            }
        }
        public DepartmentViewModel(Department department)
        {
            this.Department = department;
            EmployeeCollection = new ObservableCollection<EmployeeViewModel>();
            foreach (Employee employee in Department.EmployeeList)
            {
                EmployeeCollection.Add(new EmployeeViewModel(employee));
            }
        }
         


    }
}
