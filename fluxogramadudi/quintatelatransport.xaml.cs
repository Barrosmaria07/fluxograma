using Microsoft.Maui.Controls;

namespace fluxogramadudi
{
    public partial class quintatelatransport : ContentPage
    {
        public quintatelatransport()
        {
            InitializeComponent();
        }

        private async void OnYesButtonClicked(object sender, EventArgs e)
        {
            // Logic to delete the carrier goes here
            await Navigation.PopModalAsync(); // Dismiss the dialog after deletion
        }

        private async void OnNoButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(); // Dismiss the dialog without deleting
        }
    }
}
