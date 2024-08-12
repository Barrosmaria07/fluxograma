using LiteDB;

namespace Modelos
{
public class  Vendas: Registro

{
   public string nomedoproduto {get; set;}
   public int quantidade {get; set;}

    [BsonId]
    int id  {get; set;}
   
}
}