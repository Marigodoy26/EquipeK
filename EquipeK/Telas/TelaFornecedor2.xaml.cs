using Microsoft.Maui.Controls;
using System;

namespace EquipeK
{
    public partial class TelaFornecedor2 : ContentPage
    {
        public TelaFornecedor2()
        {
            InitializeComponent();
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