using Microsoft.Maui.Controls;
using System.Collections.ObjectModel; // For ObservableCollection

namespace fluxogramadudi
{
    public partial class primeiratelafuncionario : ContentPage
    {
        public primeiratelafuncionario Employees { get; } = new();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this; 

            // Sample employee data (replace with your actual data source)
            Employees.Add(new Employee { Name = "Nome do funcionário" });
            Employees.Add(new Employee { Name = "Nome do funcionário" });
            // ... more employees
        }

        private void OnEntrarClicked(object sender, EventArgs e)
        {
            // Handle "Entrar" button click
        }

        private void OnApagarClicked(object sender, EventArgs e)
        {
            // Handle "Apagar?" button click
        }

        private void OnAtualizarClicked(object sender, EventArgs e)
        {
            // Handle "Atualizar?" button click
        }
    }

    public class Employee
    {
        public string Name { get; set; }
    }
}
