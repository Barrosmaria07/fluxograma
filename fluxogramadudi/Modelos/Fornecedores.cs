namespace Modelos
{
public class Fornecedores : Registro
{
    string nome;
    string telefone;
    int id;
    public void Setnome (string nome)
 {
        this.nome=nome;
    }
        public string Getnome()
        {
            return nome;
        }
    
     public void Settelefone (string telefone)
     {
      this.telefone=telefone;
     }
       public string Gettelefone()
        {
            return telefone;
        }
           public void Setid(int id)
     {
      this.id = id;
     }
       public int Getid()
        {
            return id;
        }
  }
}

