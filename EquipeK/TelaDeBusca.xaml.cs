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

        private void VoltarClicked(object sender, EventArgs e)
        {
            // Handle "Voltar" button click event
            DisplayAlert("Voltar", "Voltar button clicked", "OK");
        }

        private void CadastrarClicked(object sender, EventArgs e)
        {
            // Handle "Cadastrar" button click event
            DisplayAlert("Cadastrar", "Cadastrar button clicked", "OK");
        }

        private void ContinuarClicked(object sender, EventArgs e)
        {
            // Handle "Continuar" button click event
            DisplayAlert("Continuar", "Continuar button clicked", "OK");
        }
        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new CadastroClientePage();
            page.cliente = e.SelectedItem as Cliente;
            Application.Current.MainPage = page;
        }

    }
}