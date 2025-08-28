using Microsoft.Maui.Controls;

namespace LoginAppV2025.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private async void PerfilButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PerfilPage());
        }
    }
}