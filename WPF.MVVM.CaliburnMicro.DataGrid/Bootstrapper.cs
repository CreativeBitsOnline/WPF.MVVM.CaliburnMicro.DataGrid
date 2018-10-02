using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.MVVM.CaliburnMicro.DataGrid.ViewModels;

namespace WPF.MVVM.CaliburnMicro.DataGrid
{
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            // Sets a viewmodel to start with
            DisplayRootViewFor<ShellViewModel>();
        }
    }
}
