using Microsoft.Maui.Controls;
using System;

namespace EquipeK
{
    public partial class TelaFornecedor : ContentPage
    {
        public TelaFornecedor()
        {
            InitializeComponent();
        }

        private void OnInicioButtonClicked(object sender, EventArgs e)
        {
            // Handle "Início" button click event
            DisplayAlert("Início", "Início button clicked", "OK");
        }

        private void OnClienteButtonClicked(object sender, EventArgs e)
        {
            // Handle "Cliente" button click event
            DisplayAlert("Cliente", "Cliente button clicked", "OK");
        }

        private void OnFornecedorButtonClicked(object sender, EventArgs e)
        {
            // Handle "Fornecedor" button click event
            DisplayAlert("Fornecedor", "Fornecedor button clicked", "OK");
        }

        private void OnMateriaPrimaButtonClicked(object sender, EventArgs e)
        {
            // Handle "Matéria-prima" button click event
            DisplayAlert("Matéria-prima", "Matéria-prima button clicked", "OK");
        }

        private void OnSetoresButtonClicked(object sender, EventArgs e)
        {
            // Handle "Setores" button click event
            DisplayAlert("Setores", "Setores button clicked", "OK");
        }

        private void OnPedidosButtonClicked(object sender, EventArgs e)
        {
            // Handle "Pedidos" button click event
            DisplayAlert("Pedidos", "Pedidos button clicked", "OK");
        }
    }
}