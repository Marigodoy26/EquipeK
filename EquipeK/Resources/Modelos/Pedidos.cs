namespace Modelos;

public class Pedidos
{
    string Nome;
    string Email;
    string Endereco;
    string Telefone;
    string Unidade;
    string Produto;
    string Quantidade;
    string Valor;
    string Codigo;

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

     public void SetUnidade (string U)
    {
       Unidade= U; 
    }
    public string GetUnidade()
    {
        return Unidade;
    }

      public void SetProduto (string P)
    {
       Produto= P; 
    }
    public string GetProduto()
    {
        return Produto;
    }

     public void SetQuantidade (string Q)
    {
       Quantidade= Q; 
    }
    public string GetQuantidade()
    {
        return Quantidade;
    }

     public void SetValor (string V)
    {
       Valor= V; 
    }
    public string GetValor()
    {
        return Valor;
    }

       public void SetCodigo (string C)
    {
       Codigo= C; 
    }
    public string GetCodigo()
    {
        return Codigo;
    }


}