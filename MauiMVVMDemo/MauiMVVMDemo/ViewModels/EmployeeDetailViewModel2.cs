using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMVVMDemo.ViewModels
{
    public partial class EmployeeDetailViewModel2:ObservableObject
    {
        [ObservableProperty]
        private string employeeId;
        [ObservableProperty]
        private string employeeName;
        [ObservableProperty]
        private string email;
        [ObservableProperty]
        private bool isPartTimer;
    }
}
