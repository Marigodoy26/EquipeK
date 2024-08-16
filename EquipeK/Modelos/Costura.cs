using LiteDB;

namespace Modelos;

public class Costura
{
    string Quantidade { get; set; }
    string Aviamento { get; set; }
    string NumeroOP { get; set; }

    [BsonId]
  Int64 Id { get; set; }
}