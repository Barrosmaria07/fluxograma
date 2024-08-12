using LiteDB;

namespace Modelos
{
public class Produtos: Registro
{
   public string nome {get; set;}
   public int quantidade {get; set;}

     [BsonId]
    public int id {get; set;}
   
}
}
