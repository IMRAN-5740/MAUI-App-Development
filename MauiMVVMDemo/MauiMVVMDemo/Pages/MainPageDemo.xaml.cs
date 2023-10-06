using MauiMVVMDemo.ViewModels;

namespace MauiMVVMDemo.Pages;

public partial class MainPageDemo : ContentPage
{
	public MainPageDemo()
	{
		InitializeComponent();
	}

    private void employee1_Clicked(object sender, EventArgs e)
    {
        var employeeDetailViewModel = new EmployeeDetailViewModel2
        {
            EmployeeId = "Emp001",
            EmployeeName = "Basar Ovi",
            Email = "basarovi.vivasoft.com",
            IsPartTimer = false,
        };
        var employeeDetailPage = new EmployeeDetailPage();
        employeeDetailPage.BindingContext = employeeDetailViewModel;
        Navigation.PushAsync(employeeDetailPage);
    }

    private void employee3_Clicked(object sender, EventArgs e)
    {
        var employeeDetailViewModel = new EmployeeDetailViewModel2
        {
            EmployeeId = "Emp002",
            EmployeeName = "Mohammad Imran",
            Email = "imranbsmrstucse@gmail.com",
            IsPartTimer = true,
        };
        var employeeDetailPage = new EmployeeDetailPage();
        employeeDetailPage.BindingContext = employeeDetailViewModel;
        Navigation.PushAsync(employeeDetailPage);
    }

    private void employee2_Clicked(object sender, EventArgs e)
    {
        var employeeDetailViewModel = new EmployeeDetailViewModel2
        {
            EmployeeId = "Emp003",
            EmployeeName = "Marajul Islam",
            Email = "marajulislam@gmail.com",
            IsPartTimer = false,
        };
        var employeeDetailPage = new EmployeeDetailPage();
        employeeDetailPage.BindingContext = employeeDetailViewModel;
        Navigation.PushAsync(employeeDetailPage);
    }
}