using Microsoft.Maui.Controls;

namespace fluxogramadudi // Substitua 'SeuApp' pelo nome real do seu projeto
{
    public partial class setimatelafornecedor : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCadastrarClicked(object sender, EventArgs e)
        {
            string nomeUsuario = NomeUsuarioEntry.Text;
            string email = EmailEntry.Text;
            string telefone = TelefoneEntry.Text;
            string endereco = EnderecoEntry.Text;

            // Lógica para processar os dados de cadastro (validar, salvar, etc.)
            DisplayAlert("Sucesso!", "Dados cadastrados com sucesso.", "OK");
        }
    }
}
