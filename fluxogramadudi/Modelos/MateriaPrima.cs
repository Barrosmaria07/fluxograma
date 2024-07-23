
namespace Modelos
{
public class MateriaPrima: Registro
{
    string nome;
    int unidade;
    string transportadora;
    string fornecedor;
    int id;
    public void SetNome (string nome)
 {
        this.nome=nome;
    }
        public string GetNome()
        {
            return nome;
        }
    
     public void Setunidade (int unidade)
     {
      this.unidade=unidade;
     }
       public int Getunidade()
        {
            return unidade;
        }
      public void Settransportadora (string transportadora)
      {
        this.transportadora=transportadora;
      }
        public string Gettransportadora()
        {
            return transportadora;
  }
   public void Setfornecedor (string fornecedor)
      {
        this.fornecedor=fornecedor;
      }
        public string Getfornecedor()
        {
            return fornecedor;
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