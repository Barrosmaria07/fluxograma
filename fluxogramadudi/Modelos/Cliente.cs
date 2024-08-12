using LiteDB;

namespace Modelos
{
  public class Cliente : Registro
  {

    public string nome { get; set; }
    public string telefone { get; set;}
    public string email { get; set;}

    [BsonId]
    public int id { get; set; }

  }
}

