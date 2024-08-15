using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace fluxogramadudi
{
    public partial class sextatelaproduto : ContentPage
    {
        // Exemplo de dados para a lista de itens
        public List<Item> Itens { get; set; } = new List<Item>
        {
            new Item { Produto = "Tecido", Quantidade = "2 mil", Fornecedor = "Botões e Aviamentos" },
            new Item { Produto = "Botão", Quantidade = "6443", Fornecedor = "Botões e Aviamentos" },
            new Item { Produto = "Linha", Quantidade = "421", Fornecedor = "Botões e Aviamentos" },
            // Adicione mais itens conforme necessário
        };

        public sextatelaproduto()
        {
            InitializeComponent();
            BindingContext = this;
        }

        // Evento de clique do botão "Adicionar Item"
        private void OnAddItemClicked(object sender, EventArgs e)
        {
            // Lógica para adicionar um novo item à lista
            // Por exemplo, exibir um prompt para inserir dados do novo item
        }
    }

    // Classe de modelo para os itens
    public class Item
    {
        public string Produto { get; set; }
        public string Quantidade { get; set; }
        public string Fornecedor { get; set; }
    }
}
