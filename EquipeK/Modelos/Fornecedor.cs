namespace Modelos;

public class Fornecedor
{
    string Nome;
    string Email;
    string Endereco;
    string Telefone;
    string Materia;
    string NomeMateria;
    string Valor;
    Int64 Id;
    public void SetNome (string N)
    {
       Nome= N; 
    }
    public string GetNome()
    {
        return Nome;
    }

    public void SetEmail (string E)
    {
       Email= E; 
    }
    public string GetEmail()
    {
        return Email;
    }

     public void SetEndereco (string EN)
    {
       Endereco= EN; 
    }
    public string GetEndereco()
    {
        return Endereco;
    }
     public void SetTelefone (string T)
    {
       Telefone= T; 
    }
    public string GetTelefone()
    {
        return Telefone;
    }
     public void SetMateria (string V)
    {
       Materia= V; 
    }
    public string GetMateria()
    {
        return Materia;
    }
      public void SetNomeMateria (string NM)
    {
       NomeMateria= NM; 
    }
    public string GetNomeMateria()
    {
        return NomeMateria;
    }

     public void SetValor (string VL)
    {
       Valor= VL; 
    }
    public string GetValor()
    {
        return Valor;
    }


}