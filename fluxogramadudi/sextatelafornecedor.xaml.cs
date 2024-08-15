using Microsoft.Maui.Controls;
using Modelos;

namespace fluxogramadudi // Substitua 'SeuApp' pelo nome real do seu projeto
{
    public partial class sextatelaforncedor : ContentPage
    {
        public sextatelaforncedor()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            string Nome = NomeEntry.Text;
            string Email = EmailEntry.Text;
            string Telefone = TelefoneEntry.Text;
            string Endereco = EnderecoEntry.Text;

            // Lógica para processar os dados do cliente (salvar, enviar, etc.)
        }
    }
}
