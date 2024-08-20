using LiteDB;

namespace Modelos
{
public class Compras: Registro

{
    public string Produtos {get; set;}

    public string Item {get; set;}
    
    public string Fornecedor {get; set;}
    
    public decimal Valor {get; set;}
    
    public string Estoque {get; set;}
    public int Quantidade {get; set;}

    [BsonId]
     public int Id {get; set;}
    
}
}
  