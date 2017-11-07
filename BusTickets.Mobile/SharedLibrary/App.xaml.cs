using SharedLibrary.ViewModel;
using SharedLibrary.Views;
using System.Diagnostics;

using Xamarin.Forms;

namespace SharedLibrary
{
    public partial class App : Application
    {
        public App()
        {
            MainPage = new NavigationPage(GetMainPage());
        }
        private static ViewModelLocator locator;
        public static ViewModelLocator Locator
        {
            get
            {
                return locator ?? (locator = new ViewModelLocator());
            }
        }
        public static Page GetMainPage()
        {
            return new MainPage();
        }

        protected override void OnStart()
        {
            Debug.WriteLine("OnStart");
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("OnSleep");
        }

        protected override void OnResume()
        {
            Debug.WriteLine("OnSleep");
        }
    }
}