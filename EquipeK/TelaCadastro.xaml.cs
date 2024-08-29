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

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicialPage(); // Certifique-se de que esta classe existe e está correta
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

        private void OnAtualizarButtonClicked(object sender, EventArgs e)
        {
            // Handle "Atualizar" button click event
            DisplayAlert("Atualizar", "Atualizar button clicked", "OK");
        }

        private void OnContinuarButtonClicked(object sender, EventArgs e)
        {
            // Handle "Continuar" button click event
            DisplayAlert("Continuar", "Continuar button clicked", "OK");
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

    // Certifique-se de que esta classe existe e herda de ContentPage
    internal class TelaInicialPage : ContentPage
    {
    }
}
