using LiteDB;

namespace Modelos
{
  public class Cliente : Registro
  {

    public string Nome { get; set; }
     public string Endereco { get; set; }
    public string Telefone { get; set;}
    public string Email { get; set;}

    [BsonId]
    public int Id { get; set; }

  }
}

