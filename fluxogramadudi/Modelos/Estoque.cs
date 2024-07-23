namespace Modelos
{
public class Estoque: Registro
{

    string produtos;
    int quantidade;
    int id;
    public void Setprodutos (string produtos)
 {
        this.produtos=produtos;
    }
        public string Getprodutos()
        {
            return produtos;
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
