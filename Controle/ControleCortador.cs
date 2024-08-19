using Modelos;
namespace Controle
{
    public class ControleCortador : ControleBase
    {
        public override void criar (Registro o)
        {
        }
        public override void atualizar (Registro o)
        {
        }
        public override void apagar (int id)
        {
        }
        public override Registro ler (int id)
        {
            return null;
        }
    }

    public class EstadoControle : BaseControle
    {

  public ControleCortador() : base()
  {
    NomeDaTabela = "Cortador";
  }

  public virtual Registro? Ler(int idCortador)
  {
    var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
    return collection.FindOne(d => d.Id == idCortador);
  }

  public virtual List<Cortador>? LerTodos()
  {
    var tabela = liteDB.GetCollection<Cortador>(NomeDaTabela);
    return new List<Cortador>(tabela.FindAll());
  }

  public virtual void Apagar(int idCortador)
  {
    var collection = liteDB.GetCollection<Cortador>(NomeDaTabela);
    collection.Delete(idCortador);
  }

  public virtual void CriarOuAtualizar(Cortador cortador)
  {
    var collection = liteDB.GetCollection<Cortador>(NomeDaTabela);
    collection.Upsert(ControleCortador);
  }

    }       
}