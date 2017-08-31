using Prism.Unity;
using Xamarin.Forms;
using Prism.Navigation;
using Microsoft.Practices.Unity;
using PrismSetup.Views;

namespace PrismSetup
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();
            
            NavigationService.NavigateAsync($"{nameof(HiPrismPage)}");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<HiPrismPage>();
        }
    }
}
