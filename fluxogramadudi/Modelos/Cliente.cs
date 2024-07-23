namespace Modelos 
{
public class Cliente: Registro
{

    string nome;
    string telefone;
    string email;
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
      public void Setemail (string email)
      {
        this.email=email;
      }
        public string Getemail()
        {
            return email;
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


