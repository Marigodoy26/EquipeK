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
                Nome.Text = cliente.Nome;
                Email.Text = cliente.Email;
                Telefone.Text = cliente.Telefone;
                CPF.Text = cliente.CPF;
                Endereco.Text = cliente.Endereco;
            }
        }

        private void ButtonAtualizar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaDeBusca();
        }

        private void ButtonContinuar(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaDeBusca();
        }

        private void ButtonVoltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaInicial();
        }

        


        private async Task<bool> ValidateEntriesAsync()
        {
            if (string.IsNullOrEmpty(Nome.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (string.IsNullOrEmpty(Email.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
            }
            else if (string.IsNullOrEmpty(Telefone.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
                return false;
            }

            else if (string.IsNullOrEmpty(CPF.Text))
           {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
           }
            else if (string.IsNullOrEmpty(Endereco.Text))
           {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
           }

            else
            {
                return true;
            }
        }
    }

    internal class TelaInicialPage : Page
    {
    }
}

