namespace Modelos;

public class Bordado
{
    string Quantidade;
    string Linha;
    string NumerodaOP;
     Int64 Id;

     public void SetQuantidade (string Q)
    {
       Quantidade= Q; 
    }
    public string GetQuantidade()
    {
        return Quantidade;
    }

      public void SetLinha (string L)
    {
       Linha= L; 
    }
    public string GetLinha()
    {
        return Linha;
    }

      public void SetNomedaOP (string N)
    {
       NumerodaOP= N; 
    }
    public string GetNumerodaOP()
    {
        return NumerodaOP;
    }
}