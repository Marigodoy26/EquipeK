using LiteDB;

namespace Modelos;

public class Produto : Registro
{
    string NomedaOP { get; set; }
    string NomeTecido { get; set; }
    string QuantidadeTecido { get; set; }
    string Preco { get; set; }
    string Linha { get; set; }
    string Aviamento { get; set; }
    string Cortador { get; set; }
    string Estampa { get; set; }
    string Grade { get; set; }

    [BsonId]
     Int64 Id { get; set; }
}