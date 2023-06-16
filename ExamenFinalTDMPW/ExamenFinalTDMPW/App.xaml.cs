namespace ExamenFinalTDMPW;
using ExamenFinalTDMPW.MVVM.VIEW;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Principal();
	}
}

