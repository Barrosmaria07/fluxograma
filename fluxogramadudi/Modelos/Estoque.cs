using LiteDB;

namespace Modelos
{
public class Estoque: Registro
{

    public string produtos {get; set;}
    public int quantidade {get; set;}

    [BsonId]
    public int id {get; set;}
    
}
}