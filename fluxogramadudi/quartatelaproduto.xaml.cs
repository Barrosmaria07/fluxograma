namespace fluxogramadudi;
public partial class EstoquePage : ContentPage
{
    public EstoquePage()
    {
        InitializeComponent();
    }

    private async void Itens_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ItensPage()); // Substitua ItensPage pela sua página de itens
    }

    private async void Compra_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CompraPage()); // Substitua CompraPage pela sua página de compras
    }

    private async void Baixa_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new BaixaPage()); // Substitua BaixaPage pela sua página de baixas
    }
}
