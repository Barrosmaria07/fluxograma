namespace Modelos
{
public class  Vendas: Registro

{
    string nomedoproduto;
    int quantidade;
    int id;
    public void SetNomedoproduto (string nomedoproduto)
 {
        this.nomedoproduto=nomedoproduto;
    }
        public string GetNomedoproduto()
        {
            return nomedoproduto;
        }
    
     public void Setquantidade(int quantidade)
     {
      this.quantidade= quantidade;
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