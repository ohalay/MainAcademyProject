using System.Diagnostics;

using Xamarin.Forms;

namespace SharedLibrary
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new SharedLibrary.Page1();
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