using MauiMVVMDemo.Models;
using MauiMVVMDemo.ViewModels;

namespace MauiMVVMDemo.Pages;

public partial class EmployeeListPage : ContentPage
{
	public EmployeeListPage()
	{
		InitializeComponent();
		BindingContext = new EmployeesViewModel();
	}

    private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		var employee = (Employee)e.Item;
		var employeeViewModel = new EmployeeDetailViewModel2
		{
			Employee = employee,
		};
		var employeeDetailPage = new EmployeeDetailPage();
		employeeDetailPage.BindingContext = employeeViewModel;
		await Navigation.PushAsync(employeeDetailPage);

    }
}