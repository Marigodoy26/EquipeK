namespace Modelos;

public class Produto
{
    string NumerodaOP;
    string NomeTecido;
    string QuantidadeTecido;
    string Preco;
    string Linhaa;
    string Aviamento;
    string Cortador;
    string Estampa;
    string Grade;

     Int64 Id; 


     public void SetNomedaOP (string N)
    {
       NomedaOP= N; 
    }
    public string GetNomedaOP()
    {
        return NomedaOP;
    }

     public void NomeTecido (string NT)
    {
       NomeTecido= NT; 
    }
    public string GetNomeTecido()
    {
        return NomeTecido;
    }

     public void QuantidadeTecido (string QT)
    {
       QuantidadeTecido= QT; 
    }
    public string QuantidadeTecido()
    {
        return QuantidadeTecido;
    }

     public void Preco (string P)
    {
       Preco= P; 
    }
    public string Preco()
    {
        return Preco;
    }

     public void Linha (string L)
    {
       Linha= L; 
    }
    public string Linha()
    {
        return Linha;
    }

     public void Aviamento (string A)
    {
       Aviamento= A; 
    }
    public string Aviamento()
    {
        return Aviamento;
    }

    public void Cortador (string C)
    {
       Cortador= C; 
    }
    public string Cortador()
    {
        return Cortador;
    }

    public void Estampa (string E)
    {
       Estampa= E; 
    }
    public string Estampa()
    {
        return Estampa;
    }

    public void Grade (string G)
    {
       Grade= G; 
    }
    public string Grade()
    {
        return Grade;
    }
}