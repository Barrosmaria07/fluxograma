using Microsoft.Maui.Controls;

namespace fluxogramadudi // Replace 'SeuApp' with your project's namespace
{
    public partial class segundatelafuncionario : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnFazerCadastroClicked(object sender, EventArgs e)
        {
            // Lógica para navegar para a página de cadastro
            Navigation.PushAsync(new CadastroPage()); // Assuming you have a CadastroPage
        }

        // Add search logic here to show/hide NenhumEncontradoLabel based on search results
        private void EmployeeSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            NenhumEncontradoLabel.IsVisible = EmployeeSearch.Text != "" && /* no results found */;
        }
    }
}
