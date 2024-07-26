namespace Modelos;

public class Costura
{
    string Quantidade;
    string Aviamento;
    string NumeroOP;

    public void Quantidade (string QT)
    {
       Quantidade= QT; 
    }
    public string Quantidade()
    {
        return Quantidade;
    }

    public void Aviamento (string A)
    {
        Aviamento= A
    }
    public string Aviamento ()
    {
        return Aviamento;
    }
    
}