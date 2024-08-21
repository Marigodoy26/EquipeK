using LiteDB;

namespace Modelos;

public class Fornecedor : Registro
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Endereco { get; set; }
    public string Telefone { get; set; }
    public string Materia { get; set; }
    public string NomeMateria { get; set; }
    public string Valor { get; set; }
    public string CPF { get; set; }

    [BsonId]
    Int64 Id { get; set; }

}