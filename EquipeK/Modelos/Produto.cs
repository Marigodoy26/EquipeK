namespace Modelos;

public class Produtor
{
    string NumerodaOP;
    string NomeTecido;
    string QuantidadeTecido;
    string Preco;
    string Linha;
    string Aviamento;
    string Cortador;
    string Estampa;
    string Grade;

     public void SetNomedaOP (string N)
    {
       NomedaOP= N; 
    }
    public string GetNomedaOP()
    {
        return NomedaOP;
    }

     public void NomeTecido (string N)
    {
       NomeTecido= N; 
    }
    public string GetNomeTecido()
    {
        return NomeTecido;
    }
}