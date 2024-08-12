using LiteDB;

namespace Modelos
{
public class Fornecedores : Registro
{
    public string nome {get; set;}
     public string telefone {get; set;}

    [BsonId]
    public int id {get; set;}
   
}
}
