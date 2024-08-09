namespace Modelos;

public class Estoque
{
    string Quantidade;
    string Cliente;
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

      public void SetCliente (string C)
    {
       Cliente= C; 
    }
    public string GetCliente()
    {
        return Cliente;
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
