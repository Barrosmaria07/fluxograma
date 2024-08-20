using Microsoft.Maui.Controls;

namespace fluxogramadudi
{
public partial class quartatelaproduto : ContentPage
{
    public quartatelaproduto()
    {
        InitializeComponent();
    }

    private async void Itens_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new quartatelaproduto()); // Substitua ItensPage pela sua página de itens
    }

    private async void Compra_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new quartatelaproduto()); // Substitua CompraPage pela sua página de compras
    }

    private async void Baixa_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new quartatelaproduto()); // Substitua BaixaPage pela sua página de baixas
    }
}
}