using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MAUISql.Data;
using MAUISql.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUISql.ViewModels
{
    public partial class ProductsViewModel:ObservableObject
    {
        private readonly ApplicationDbContext _context;
        public ProductsViewModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [ObservableProperty]
        private ObservableCollection<Product> _products;

        [ObservableProperty]
        private Product _operatingProduct=new();

        [ObservableProperty]
        private bool _isBusy;
        [ObservableProperty]
        private string _busyText;



        [RelayCommand]
        private async Task LoadProductsAsync()
        {
            await ExecuteAsynce(async () =>
            {
                var products = await _context.GetAllAsync<Product>();
                if (products is not null && products.Any())
                {
                    Products ??= new ObservableCollection<Product>();
                    foreach (var product in products)
                    {
                        Products.Add(product);
                    }
                }
            },"Fetching Product");
        }


        [RelayCommand]
        private void SetOperatingProduct(Product? product) => OperatingProduct = product ?? new();

        [RelayCommand]
        private async Task SaveProductAsync()
        {

            if (OperatingProduct is null)
             return;

            var busyText = OperatingProduct.Id == 0 ? "Creating Product" : " Updating Product";

            await ExecuteAsynce(async () =>
            {
                if (OperatingProduct.Id == 0)
                {
                    //Create
                    await _context.AddItemAsync<Product>(OperatingProduct);
                    Products.Add(OperatingProduct);
                }

                else
                {
                    //update
                    await _context.UpdateItemAsync<Product>(OperatingProduct);
                    var copyProduct = OperatingProduct.Clone();
                    var index = Products.IndexOf(OperatingProduct);
                    Products.RemoveAt(index);

                    Products.Insert(index, copyProduct);

                }
            }, busyText);
           
            SetOperatingProductCommand.Execute(new());
        }

        [RelayCommand]
        private async Task DeleteProductAsync(int id)
        {
            await ExecuteAsynce(async() =>
            {
                if (await _context.DeleteItemByKeyAsync<Product>(id))
                {
                    var product = Products.FirstOrDefault(data => data.Id == id);
                    Products.Remove(product);
                }
                else
                {
                    await Shell.Current.DisplayAlert("Delete Error", "Product was not Deletedd", "Ok");
                }
            }, "Deleting Product...");
           
        }


        private async Task ExecuteAsynce(Func<Task> operation,string? busyText=null)
        {
            IsBusy=true;
            BusyText = busyText?? "Processing...";
            try
            {
                await operation?.Invoke();
            }
            finally {
                IsBusy = false;
                BusyText = "Processing";
            }
        }
    }
}
