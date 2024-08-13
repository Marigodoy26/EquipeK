using Microsoft.Maui.Controls;
using System;

namespace EquipeK
{
    public partial class TelaFornecedor3 : ContentPage
    {
        public TelaFornecedor3()
        {
            InitializeComponent();
        }

        private void OnSimButtonClicked(object sender, EventArgs e)
        {
            // Handle "Sim" button click event
            DisplayAlert("Confirmação", "Você clicou em Sim", "OK");
        }

        private void OnNaoButtonClicked(object sender, EventArgs e)
        {
            // Handle "Não" button click event
            DisplayAlert("Confirmação", "Você clicou em Não", "OK");
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Handle "Voltar" button click event
            DisplayAlert("Voltar", "Voltar button clicked", "OK");
        }

        private void OnCadastrarButtonClicked(object sender, EventArgs e)
        {
            // Handle "Cadastrar" button click event
            DisplayAlert("Cadastrar", "Cadastrar button clicked", "OK");
        }

        private void OnContinuarButtonClicked(object sender, EventArgs e)
        {
            // Handle "Continuar" button click event
            DisplayAlert("Continuar", "Continuar button clicked", "OK");
        }
    }
}