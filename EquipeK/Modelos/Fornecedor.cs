using LiteDB;

namespace Modelos;

public class Fornecedor
{
    string Nome { get; set; }
    string Email { get; set; }
    string Endereco { get; set; }
    string Telefone { get; set; }
    string Materia { get; set; }
    string NomeMateria { get; set; }
    string Valor { get; set; }

    [BsonId]
    Int64 Id { get; set; }

}