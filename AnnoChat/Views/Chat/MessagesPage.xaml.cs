namespace AnnoChat.Views.Chat;

public partial class MessagesPage : ContentPage
{
	public MessagesPage()
	{
		InitializeComponent();
	}

	void CollectionView_SelectionChanged(System.Object sender, Microsoft.Maui.Controls.SelectionChangedEventArgs e)
	{
		Navigation.PushAsync(new ChatPage(), true);
	}
}

