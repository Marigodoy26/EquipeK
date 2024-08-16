using LiteDB;

namespace Modelos;

public class MateriaPrima
{
    string Nome { get; set; }
    string Tipo { get; set; }
    string Valor { get; set; }
    string Unidade { get; set; }
    string IdMateria { get; set; }

    [BsonId]
     Int64 Id { get; set; }
}
