using Microsoft.Maui.Controls;

namespace fluxogramadudi
{
    public partial class primeiratelaproduto : ContentPage
    {
        public primeiratelaproduto()
        {
            InitializeComponent();
        }
    }
    void NovoProdutoClicked(object sender, EventArgs e)
  {
    // Quando a idéia é CRIAR um novo cliente, não é necessário setar o atributo "cliente" no CadastroClientePage,
    // sendo assim, apenas criamos a nova página
    Application.Current.MainPage = new segundatelaproduto();
  }
}
