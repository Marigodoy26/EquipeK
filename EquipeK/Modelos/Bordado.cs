using LiteDB;

namespace Modelos;

public class Bordado
{
  string Quantidade { get; set; }
  string Linha { get; set; }
  string NumerodaOP { get; set; }

  [BsonId]
  Int64 Id { get; set; }
}

