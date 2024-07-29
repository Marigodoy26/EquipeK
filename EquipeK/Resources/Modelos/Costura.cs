namespace Modelos;

public class Costura
{
    string Quantidade;
    string Aviamento;
    string NumeroOP;

    public void SetQuantidade (string QT)
    {
       Quantidade= QT; 
    }
    public string GetQuantidade()
    {
        return Quantidade;
    }

    public void SetAviamento (string A)
    {
        Aviamento= A
    }
    public string GetAviamento ()
    {
        return Aviamento;
    }

    public void SetNumeroOP (string N)
    {
       NumeroOP= N; 
    }
    public string GetNumeroOP()
    {
        return NumeroOP;
    }
    
}