using Controle;
using Microsoft.Maui.Controls;
using Modelos;
using System;
using System.Threading.Tasks;

namespace EquipeK
{
    public partial class TelaCadastro : ContentPage
    {
        public Fornecedor fornecedor { get; set; }
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

            if (fornecedor != null)
            {
                // Verifique se você tem os controles apropriados no XAML
                NomeEntry.Text = fornecedor.Nome;
                EmailEntry.Text = fornecedor.Email;
                TelfEntry.Text = fornecedor.Telefone;
                CPFfEntry.Text = fornecedor.CPF;
                EndEntry.Text = fornecedor.Endereco;
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
            if (string.IsNullOrEmpty(NomeEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
                return false;
            }
            else if (string.IsNullOrEmpty(EmailEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Email é obrigatório", "OK");
                return false;
            }
            else if (string.IsNullOrEmpty(TelfEntry.Text))
            {
                await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
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
