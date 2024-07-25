namespace Modelos;

public class Clinte
{
    string Nome;
    string Email;
    string Endereco;
    string Telefone;

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
}

