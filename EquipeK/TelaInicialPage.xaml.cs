using Microsoft.Maui.Controls;
using System;

namespace EquipeK
{
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

       private void TelaDeBusca(object sender, EventArgs args)
        {
            if (Application.Current != null)
            Application.Current.MainPage = new TelaInicial();
        }

        private void buttonCliente(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaDeBusca();
        }

        private void buttonFornecedor(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaDeBusca();
        }

        private void buttonMateriaprima(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaDeBusca();
        }

        private void buttonSetores(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaDeBusca();
        }

        private void buttonPedidos(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaDeBusca();
        }

        private void ButtonVoltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaInicialPage();
        }

    }
}