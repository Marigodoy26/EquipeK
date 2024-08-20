using LiteDB;
using Modelos;
namespace Controle;

public class BaseControle
{

  protected string NomeDaTabela;
  protected static LiteDatabase liteDB = null;

  public BaseControle()
  {
    var pathToPersonalFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SESI.db");

    if (liteDB == null)
      liteDB = new LiteDatabase(@"filename=" + pathToPersonalFolder + "; upgrade=true; Mode=Exclusive");
  }

  public virtual void criar(Registro r)
  {
  }
  

  public virtual void apagar(int id)
  {
  }

  public virtual void atualizar(int id)
    {
                }

  public virtual Registro? ler(int id)
  {
    return null;
  }


  public virtual List<Registro>? LerTodos()
  {
    return null;
  }
}