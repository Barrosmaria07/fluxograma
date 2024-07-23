namespace Modelos
{
    public class Pedido : Registro
    {
        string produto;
        
        string fornecedor;
        
        decimal valor;
        
        string estoque;
        int quantidade;
        int id;
        public void Setproduto (string produto)
    {
            this.produto=produto;
        }
            public string Getproduto()
            {
                return produto;
            }
            public void Setfornecedor (string fornecedor)
    {
            this.fornecedor=fornecedor;
        }
            public string Getfornecedor()
            {
                return fornecedor;
            }
        public void Setvalor(decimal valor)
    {
            this.valor=valor;
        }
            public decimal Getvalor()
            {
                return valor;
            }
            public void Setestoque(string estoque)
    {
            this.estoque=estoque;
        }
            public string Getestoque()
            {
                return estoque;
            }

        public void Setquantidade(int quantidade)
        {
        this.quantidade=quantidade;
        }
        public int Getquantidade()
            {
                return quantidade;
            }
            public void Setid(int id)
     {
      this.id=id;
     }
       public int Getid()
        {
            return id;
        }
    }
}
