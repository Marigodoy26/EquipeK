using Controle;
using Microsoft.Maui.Controls;
using Modelos;
using System;
using System.Threading.Tasks;

namespace EquipeK
{
    public partial class TelaCadastro : ContentPage
    {
        public Cliente cliente { get; set; }
        ControleFornecedor controlefornecedor = new ControleFornecedor();

        public TelaCadastro()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
                NomeEntry.Text = cliente.Nome;
                EmailEntry.Text = cliente.Email;
                TelefoneEntry.Text = cliente.Telefone;
                CPFEntry.Text = cliente.CPF;
                EnderecoEntry.Text = cliente.Endereco;
            }
        }

        private void ButtonAtualizar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaAtualizacao();
        }

        private void ButtonContinuar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaDeBusca();
        }

        private void ButtonVoltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaInicial();
        }

        
  private async void OnSalvarDadosClicked(object sender, EventArgs e)
  {
    if (await VerificaSeDadosEstaoCorretos()) 
    {

      var cliente = new Modelos.Cliente();
      if (!String.IsNullOrEmpty(IdLabel.Text))
        cliente.Id      = int.Parse(IdLabel.Text);
      else
        cliente.Id      = 0;
      cliente.Nome      = NomeEntry.Text;
      cliente.Email = EmailEntry.Text;
      cliente.Telefone  = TelefoneEntry.Text;
       cliente.CPF  = CPFEntry.Text;
        cliente.Endereco  = EnderecoEntry.Text;




      controlefornecedor.CriarOuAtualizar(cliente);

      await DisplayAlert("Salvar", "Dados salvos com sucesso!", "OK");
    }
  }


  private async Task<bool> VerificaSeDadosEstaoCorretos()
  {
    // Verifica se a Entry do Nome está vazia
    if (String.IsNullOrEmpty(NomeEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Sobrenome está vazia
    else if (String.IsNullOrEmpty(EmailEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Sobrenome é obrigatório", "OK");
      return false;
    }
    // Verifica se a Entry do Telefone está vazia
    else if (String.IsNullOrEmpty(TelefoneEntry.Text))
    {
      await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
      return false;
    }
    else
      return true;
  }

    }

    internal class TelaInicialPage : Page
    {
    }
}

