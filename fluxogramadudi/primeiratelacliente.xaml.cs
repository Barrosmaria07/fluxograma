using Microsoft.Maui.Controls;

namespace fluxogramadudi
{
    public partial class primeiratelacliente : ContentPage
    {
        public primeiratelacliente()
        {
            InitializeComponent();

            // Example data, replace with your actual data source
            BindingContext = new[]
            {
                new { Name = "Nome do cliente", Image = "profile_placeholder.png" },
                new { Name = "Nome do cliente", Image = "profile_placeholder.png" },
                new { Name = "Nome do cliente", Image = "profile_placeholder.png" },
                new { Name = "Nome do cliente", Image = "profile_placeholder.png" },
                new { Name = "Nome do cliente", Image = "profile_placeholder.png" },
                new { Name = "Nome do cliente", Image = "profile_placeholder.png" },
                new { Name = "Nome do cliente", Image = "profile_placeholder.png" }
            };
        }
    }
}
