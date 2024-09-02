using Microsoft.Maui.Controls;
using Modelos;
using System;

namespace EquipeK
{
    public partial class TelaDeBusca : ContentPage
    {
         Controle.ControleCliente controlecliente = new Controle.ControleCliente();

        public TelaDeBusca()
        {
            InitializeComponent();
            ListaClientes.ItemsSource = controlecliente.LerTodos();
        }

        private void VoltarClicked(object sender, EventArgs e)
        {
               Application.Current.MainPage = new TelaInicial();
        }

        private void CadastrarClicked(object sender, EventArgs e)
        {
               Application.Current.MainPage = new TelaCadastro();
        }

        private void ContinuarClicked(object sender, EventArgs e)
        {
               Application.Current.MainPage = new TelaAtualizacao();
        }

        void QuandoSelecionarUmItemNaLista(object sender, SelectedItemChangedEventArgs e)
        {
            var page = new TelaCadastro();
            page.cliente = e.SelectedItem as Cliente;
            Application.Current.MainPage = page;
        }

    }
}