using Caliburn.Micro;
using ClassLibrary;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.MVVM.CaliburnMicro.DataGrid.ViewModels
{
    public class ShellViewModel : Screen
    {
        public BindableCollection<EmployeeModel> Employees1 { get; set; }
        public BindableCollection<EmployeeModel> Employees2 { get; set; }
        public BindableCollection<EmployeeModel> Employees3 { get; set; }
        public BindableCollection<EmployeeModel> Employees4 { get; set; }

        //public BindableCollection<SiteModel> Sites1 { get; set; }

        public ShellViewModel()
        {
            Employees1 = new BindableCollection<EmployeeModel>(RandomData.GetEmployees());
            Employees2 = new BindableCollection<EmployeeModel>(RandomData.GetEmployees());
            Employees3 = new BindableCollection<EmployeeModel>(RandomData.GetEmployees());
            Employees4 = new BindableCollection<EmployeeModel>(RandomData.GetEmployees());

            //Sites1 = new BindableCollection<SiteModel>(RandomData.GetSites());
        }

    }
}
