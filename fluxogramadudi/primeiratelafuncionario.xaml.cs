using Microsoft.Maui.Controls;
using System.Collections.ObjectModel; // For ObservableCollection

namespace fluxogramadudi
{
    public partial class primeiratelafuncionario : ContentPage
    {
        public primeiratelafuncionario Employees { get; } = new();

        public primeiratelafuncionario()
        {
            InitializeComponent();
            BindingContext = this; 

        }

         void OnEntrarClicked(object sender, EventArgs e)
        {
            // Handle "Entrar" button click
        }

         void OnApagarClicked(object sender, EventArgs e)
        {
            // Handle "Apagar?" button click
        }

         void OnAtualizarClicked(object sender, EventArgs e)
        {
            // Handle "Atualizar?" button click
        }
    }

    
}
