using Microsoft.Maui.Controls;
using System;

namespace EquipeK
{
    public partial class TelaAtualizacao : ContentPage
    {
        public TelaAtualizacao()
        {
            InitializeComponent();
        }

        private void OnVoltarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Voltar"
            Navigation.PopAsync();
        }

        private void OnDeletarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Deletar"
            DisplayAlert("Deletar", "O fornecedor foi deletado.", "OK");
        }

        private void OnContinuarClicked(object sender, EventArgs e)
        {
            // Lógica para o botão "Continuar"
            DisplayAlert("Continuar", "Continuando para a próxima etapa.", "OK");
        }
    }
}
