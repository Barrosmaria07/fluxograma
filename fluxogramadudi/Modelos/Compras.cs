using LiteDB;

namespace Modelos
{
public class Compras: Registro

{
    public string produtos {get; set;}
    
    public string fornecedor {get; set;}
    
    public decimal valor {get; set;}
    
    public string estoque {get; set;}
    public int quantidade {get; set;}

    [BsonId]
     public int id {get; set;}
    
}
}
  