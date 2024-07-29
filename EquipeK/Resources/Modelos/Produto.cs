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

     public void SetNomeTecido (string NT)
    {
       NomeTecido= NT; 
    }
    public string GetNomeTecido()
    {
        return NomeTecido;
    }

     public void SetQuantidadeTecido (string QT)
    {
       QuantidadeTecido= QT; 
    }
    public string GetQuantidadeTecido()
    {
        return QuantidadeTecido;
    }

     public void SetPreco (string P)
    {
       Preco= P; 
    }
    public string GetPreco()
    {
        return Preco;
    }

     public void SetLinha (string L)
    {
       Linha= L; 
    }
    public string GetLinha()
    {
        return Linha;
    }

     public void SetAviamento (string A)
    {
       Aviamento= A; 
    }
    public string GetAviamento()
    {
        return Aviamento;
    }

    public void SetCortador (string C)
    {
       Cortador= C; 
    }
    public string GetCortador()
    {
        return Cortador;
    }

    public void SetEstampa (string E)
    {
       Estampa= E; 
    }
    public string GetEstampa()
    {
        return Estampa;
    }

    public void SetGrade (string G)
    {
       Grade= G; 
    }
    public string GetGrade()
    {
        return Grade;
    }
}