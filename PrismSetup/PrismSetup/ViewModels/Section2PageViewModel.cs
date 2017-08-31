using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PrismSetup.ViewModels
{
    public class Section2PageViewModel : BindableBase, INavigationAware
    {
        private readonly INavigationService _navigationService;

        public ICommand NavigateBackPage1Command { get; set; }

        public Section2PageViewModel(INavigationService navigationService)
        {
            NavigateBackPage1Command = new Command(async() => await OnNavigateBackPage1());

            _navigationService = navigationService;
        }

        async Task OnNavigateBackPage1()
        {
            await _navigationService.GoBackAsync();
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
