using LiteDB;

namespace Modelos;

public class Estoque : Registro
{
    string Quantidade { get; set; }
    string Cliente { get; set; }
    string NumerodaOP { get; set; }

    [BsonId]
     Int64 Id { get; set; }
}