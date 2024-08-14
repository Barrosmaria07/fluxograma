using Microsoft.Maui.Controls;

namespace fluxogramadudi // Substitua 'SeuApp' pelo nome real do seu projeto
{
    public partial class quintatelafornecedor : ContentPage
    {
        public quintatelafornecedor()
        {
            InitializeComponent();

            SimButton.Clicked += (sender, args) =>
            {
                // Lógica para quando o usuário clicar em "Sim" (por exemplo, apagar o cliente)
                DisplayAlert("Sim", "Cliente apagado!", "OK");
            };

            NaoButton.Clicked += (sender, args) =>
            {
                // Lógica para quando o usuário clicar em "Não" (por exemplo, cancelar a operação)
                DisplayAlert("Não", "Operação cancelada!", "OK");
            };
        }
    }
}
