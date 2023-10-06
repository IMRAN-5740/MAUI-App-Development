using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiMVVMDemo.ViewModels
{
    public class EmployeeDetailViewModel:INotifyPropertyChanged
    {
        private string employeeName;
        public string EmployeeId {  get; set; }
        public string EmployeeName { 
            get
            {
                return employeeName;
            } 
            set 
            {
                employeeName= value;
                NotifyPropertyChanged(nameof(EmployeeName));
            } 
        }
        public string Email {  get; set; }
        public bool IsPartTimer { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged( string propertyName)
        {
            PropertyChanged?.Invoke( this, new PropertyChangedEventArgs( propertyName ) );
        }
    }
}
