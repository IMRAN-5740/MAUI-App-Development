using CommunityToolkit.Mvvm.ComponentModel;
using MauiMVVMDemo.Models;
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
        private Employee employee;
    }
}
