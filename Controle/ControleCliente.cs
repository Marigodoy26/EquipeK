using Modelos;
namespace Controle
{
    public class ControleCliente : ControleBase
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

            public ControleCliente() : base()
        {
            NomeDaTabela = "Clientes";
        }

        public virtual Registro? Ler(int idCliente)
        {
            var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
            return collection.FindOne(d => d.Id == idCliente);
        }

        public virtual List<Cliente>? LerTodos()
        {
            var tabela = liteDB.GetCollection<Cliente>(NomeDaTabela);
            return new List<Cliente>(tabela.FindAll());
        }

        public virtual void Apagar(int idCliente)
        {
            var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
            collection.Delete(idCliente);
        }
 
        public virtual void CriarOuAtualizar(Cliente cliente)
        {
            var collection = liteDB.GetCollection<Cliente>(NomeDaTabela);
            collection.Upsert(cliente);
        }

}
