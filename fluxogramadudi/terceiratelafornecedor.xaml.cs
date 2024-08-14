using Microsoft.Maui.Controls;

namespace fluxogramadudi
{
    public partial class terceiratelafornecedor : ContentPage
    {
        public terceiratelafornecedor()
        {
            InitializeComponent();

            var stackLayout = new StackLayout
            {
                Padding = new Thickness(20)
            };

            var titleLabel = new Label
            {
                Text = "Página de cadastro",
                FontSize = 24,
                HorizontalOptions = LayoutOptions.Center,
                Margin = new Thickness(0, 20, 0, 20)
            };

            var nomeEntry = new Entry
            {
                Placeholder = "Nome do Fornecedor",
                BackgroundColor = Colors.Pink,
                Margin = new Thickness(0, 0, 0, 10)
            };

            var emailEntry = new Entry
            {
                Placeholder = "E-mail",
                BackgroundColor = Colors.Pink,
                Margin = new Thickness(0, 0, 0, 10)
            };

            var telefoneEntry = new Entry
            {
                Placeholder = "Telefone",
                BackgroundColor = Colors.Pink,
                Margin = new Thickness(0, 0, 0, 10)
            };

            var enderecoEntry = new Entry
            {
                Placeholder = "Endereço",
                BackgroundColor = Colors.Pink,
                Margin = new Thickness(0, 0, 0, 20)
            };

            var irButton = new Button
            {
                Text = "Ir",
                BackgroundColor = Colors.Pink,
                TextColor = Colors.White,
                HorizontalOptions = LayoutOptions.Center
            };

            stackLayout.Children.Add(titleLabel);
            stackLayout.Children.Add(nomeEntry);
            stackLayout.Children.Add(emailEntry);
            stackLayout.Children.Add(telefoneEntry);
            stackLayout.Children.Add(enderecoEntry);
            stackLayout.Children.Add(irButton);

            Content = stackLayout;
        }
    }
}
