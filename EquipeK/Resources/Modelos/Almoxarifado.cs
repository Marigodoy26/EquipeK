namespace Modelos;

public class Almoxarifado
{
    string Quantidade;
    string Materia;
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

      public void SetMateria (string M)
    {
       Materia.= M; 
    }
    public string GetMateria()
    {
        return Materia;
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