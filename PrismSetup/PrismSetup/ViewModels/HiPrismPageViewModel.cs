using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismSetup.ViewModels
{
    public class HiPrismPageViewModel : BindableBase, INavigationAware
    {
        public string Message { get; set; }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
             
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Message = "Prism Me Baby!";
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
             
        }
    }
}
