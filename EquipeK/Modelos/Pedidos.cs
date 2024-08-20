using LiteDB;

namespace Modelos;

public class Pedidos : Registro

{
    string Nome { get; set; }
    string Email { get; set; }
    string Endereco { get; set; }
    string Telefone { get; set; }
    string Unidade { get; set; }
    string Produto { get; set; }
    string Quantidade { get; set; }
    string Valor { get; set; }
    string Codigo { get; set; }

    [BsonId]
    Int64 Id { get; set; }
}