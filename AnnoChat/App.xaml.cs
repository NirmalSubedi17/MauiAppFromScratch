namespace AnnoChat;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Views.Main.MainPage();
	}
}
