using Prism.Mvvm;
using Prism.Navigation;
using PrismSetup.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrismSetup.ViewModels
{
    public class Section1PageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        public ICommand NavigatePage2Command { get; set; }

        public Section1PageViewModel(INavigationService navigationService)
        {
            NavigatePage2Command = new Command(async()=> await OnNavigatePage2());

            _navigationService = navigationService;
        }

        async Task OnNavigatePage2()
        {
            await _navigationService.NavigateAsync($"{nameof(Section2Page)}");
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
             
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
             
        }
    }
}
