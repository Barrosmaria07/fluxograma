using LiteDB;

namespace Modelos
{
public class Estoque: Registro
{

    public string Produtos {get; set;}
    public int Quantidade {get; set;}

    [BsonId]
    public int Id {get; set;}
    
}
}