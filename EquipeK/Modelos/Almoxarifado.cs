using LiteDB;

namespace Modelos;

public class Almoxarifado : Registro
{
    string Quantidade { get; set; }
    string Materia { get; set; }
    string NumerodaOP { get; set; }

     [BsonId]
     Int64 Id { get; set; }
}