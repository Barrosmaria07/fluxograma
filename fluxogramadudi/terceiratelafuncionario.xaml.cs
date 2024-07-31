using Microsoft.Maui.Controls;

namespace fluxogramadudi // Replace 'SeuApp' with your project's namespace
{
    public partial class terceiratelafuncionario : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnIrClicked(object sender, EventArgs e)
        {
            // Lógica para processar os dados de cadastro (validar, salvar, etc.)
            // Aqui você pode navegar para outra página ou realizar outras ações
            DisplayAlert("Sucesso!", "Dados cadastrados com sucesso.", "OK");
        }
    }
}
