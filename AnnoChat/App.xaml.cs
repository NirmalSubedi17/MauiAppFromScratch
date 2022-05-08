using AnnoChat.Views.Account;
using AnnoChat.Views.Chat;
using AnnoChat.Views.Home;
using AnnoChat.Views.Main;

namespace AnnoChat;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new Views.Main.MainPage();
	}
}
