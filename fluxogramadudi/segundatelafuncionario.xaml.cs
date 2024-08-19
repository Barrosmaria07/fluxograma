using Microsoft.Maui.Controls;

namespace fluxogramadudi 
{
    public partial class Segundatelafuncionario : ContentPage
    {
        public Segundatelafuncionario()
        {
            InitializeComponent();
        }

        private void OnFazerCadastroClicked(object sender, EventArgs e)
        {
            // Lógica para navegar para a página de cadastro
            Navigation.PushAsync(new Segundatelafuncionario()); // Assuming you have a CadastroPage
        }

        // Add search logic here to show/hide NenhumEncontradoLabel based on search results

    internal class CadastroPage : Page
    {
    }
}
}