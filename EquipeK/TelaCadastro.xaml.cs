using Microsoft.Maui.Controls;
using System;

namespace EquipeK
{
    public partial class TelaFCadastro : ContentPage
    {
        public TelaFCadastro()
        {
            InitializeComponent();
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

         private async Task<bool> VerificaSeDadosEstaoCorretos()
        {
            // Verifica se a Entry do Nome está vazia
            if (String.IsNullOrEmpty(NomeEntry.Text))
            {
            await DisplayAlert("Cadastrar", "O campo Nome é obrigatório", "OK");
            return false;
            }
            // Verifica se a Entry do Sobrenome está vazia
            else if (String.IsNullOrEmpty(SobrenomeEntry.Text))
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
}
