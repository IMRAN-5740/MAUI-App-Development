using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiMVVMDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMVVMDemo.ViewModels
{
    public partial class EmployeesViewModel:ObservableObject
    {

        [ObservableProperty]
        private ObservableCollection<Employee> employees = new();

        [ObservableProperty]
        private Employee employee =new();
        [RelayCommand]
        private void Add()
        {
            Employees.Add(Employee);
            Employee = new();
        }
      
    }
}
