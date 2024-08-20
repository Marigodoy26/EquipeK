using LiteDB;

namespace Modelos;

public class Cortador : Registro
{
    string Nome { get; set; }

     [BsonId]
  Int64 Id { get; set; }
}