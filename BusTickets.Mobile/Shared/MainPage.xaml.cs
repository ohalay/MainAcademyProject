using BusTicketClient.Tables;
using Xamarin.Forms;

namespace Shared
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushModalAsync(new DescriptionPage((Journey)e.SelectedItem));
        }
    }
}
