
using LiteDB;

namespace Modelos
{
public class MateriaPrima: Registro
{
    public string nome {get; set;}

    public string transportadora {get; set;}
    public string fornecedor {get; set;}

     [BsonId]
    public int id {get; set;}
 
}
}