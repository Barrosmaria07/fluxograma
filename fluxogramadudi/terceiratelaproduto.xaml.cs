
public partial class terceiratelaproduto : ContentPage
{
    public EnvioPage()
    {
        InitializeComponent();
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        // Obtenha os valores dos campos
        // ... (implemente a lógica para obter os valores dos campos)

        // Faça algo com os dados, como enviar para um servidor
        await DisplayAlert("Envio", "Dados enviados com sucesso!", "OK");
    }
}
