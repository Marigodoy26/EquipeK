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
    }
}
