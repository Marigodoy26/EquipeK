namespace EquipeK;

public partial class MainPage : ContentPage
{


	public MainPage()
	{
		InitializeComponent();
	}

	private void TelaCadastro(object sender, EventArgs args)
  {
    if (Application.Current != null)
      Application.Current.MainPage = new TelaInicial();
  }
}

