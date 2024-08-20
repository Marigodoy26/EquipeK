using LiteDB;

namespace Modelos;

public class Cliente : Registro
{
    string Nome { get; set; }
    string Email { get; set; }
    string Endereco { get; set; }
    string Telefone { get; set; }

    [BsonId]
    int Id { get; set; }
}

     

