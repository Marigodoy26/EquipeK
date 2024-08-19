
using Android.Service.Controls;
using Microsoft.Maui.Controls;
using Modelos;
using System;

namespace EquipeK
{
    public partial class TelaFCadastro : ContentPage
     {
        public Fornecedor fornecedor { get; set; }
        Controle.ControleFornecedor controlefornecedor = new Control.ControleFornecedor();

        public TelaFCadastro()
        {
            InitializeComponent();
        }

        void VoltarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }

                protected override void OnAppearing()
        {
            base.OnAppearing();

            if (cliente != null)
            {
            IdLabel.Text        = fornecedor.Id.ToString();
            NomeEntry.Text      = fornecedor.Nome;
            EmailEntry.Text     = fornecedor.Email;
            TelfEntry.Text      = fornecedor.Telf;
            }
        }


        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Handle "Voltar" button click event
            DisplayAlert("Voltar", "Voltar button clicked", "OK");
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

         private async Task<bool>                                       s()
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
            else if (String.IsNullOrEmpty(TelfEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Telefone é obrigatório", "OK");
            return false;
            }
            else
            return true;
        }
    }
}
