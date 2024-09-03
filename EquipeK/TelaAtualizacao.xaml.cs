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
            Application.Current.MainPage = new TelaDeBusca();
        }

        private void OnDeletarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaCadastro();
        }

        private void OnContinuarClicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new TelaInicial();
        }
    }
}
