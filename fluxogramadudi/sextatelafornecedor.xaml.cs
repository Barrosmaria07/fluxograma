using Microsoft.Maui.Controls;

namespace fluxogramadudi // Substitua 'SeuApp' pelo nome real do seu projeto
{
    public partial class sextatelaforncedor : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            string nome = NomeEntry.Text;
            string email = EmailEntry.Text;
            string telefone = TelefoneEntry.Text;
            string endereco = EnderecoEntry.Text;

            // Lógica para processar os dados do cliente (salvar, enviar, etc.)
        }
    }
}
