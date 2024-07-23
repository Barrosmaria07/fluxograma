namespace Modelos
{
public class Produtos: Registro
{
    string nome;
    int quantidade;
    int id;
    public void SetNome (string nome)
 {
        this.nome=nome;
    }
        public string GetNome()
        {
            return nome;
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
