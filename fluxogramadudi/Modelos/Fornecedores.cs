using LiteDB;

namespace Modelos
{
public class Fornecedores : Registro
{
    public string Nome {get; set;}
     public string Telefone {get; set;}

    [BsonId]
    public int Id {get; set;}
   
}
}
