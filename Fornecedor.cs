public class Fornecedor
{
    string Nome;
    string Email;
    string Endereco;
    string Telefone;
    string TipodeMateria;
    string NomeDeMateria;
    int64 Id;
    public void SetNome (string NomeF)
    {
       Nome= NomeF; 
    }
    public string GetNome()
    {
        return Nome;
    }

}