using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SharedLibrary.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            
            BindingContext = App.Locator.Main;
            InitializeComponent();
        }
    }
}