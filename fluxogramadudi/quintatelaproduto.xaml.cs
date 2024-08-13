using System.Reflection.Metadata;

namespace fluxogramadudi;
public partial class CadastroCompraPage : ContentPage
{
    public CadastroCompraPage()
    {
        InitializeComponent();
    }

    private async void Salvar_Clicked(object sender, EventArgs e)
    {
        // Obtenha os valores dos campos
        string item = itemEntry.Text;
        int quantidade = int.Parse(quantidadeEntry.Text);
        string fornecedor = fornecedorEntry.Text;

        // Crie um objeto para representar a compra (opcional)
        var compra = new Compra { Item = item, Quantidade = quantidade, Fornecedor = fornecedor };

        // Salve os dados (implemente a lógica de salvar aqui)
        // Exemplo: salvando em um banco de dados local ou enviando para uma API
        await DisplayAlert("Sucesso", "Compra cadastrada com sucesso!", "OK");
    }
}
