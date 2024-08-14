
using LiteDB;

namespace Modelos
{
public class MateriaPrima: Registro
{
    public string Nome {get; set;}

    public string Transportadora {get; set;}
    public string Fornecedor {get; set;}

     [BsonId]
    public int Id {get; set;}
 
}
}