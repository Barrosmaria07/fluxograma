using LiteDB;

namespace Modelos
{
    public class Pedido : Registro
    {
        public string Produto {get; set;}
        
       public string Fornecedor {get; set;}
        
        public decimal Valor {get; set;}
        
        public string Estoque {get; set;}
        public int Quantidade {get; set;}

         [BsonId]
        public int Id {get; set;}

}
}