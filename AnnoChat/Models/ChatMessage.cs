using System;
namespace AnnoChat.Models
{
    public enum MessageOwner
    {
        CurrentUser,
        OtherUser
    }

	public class ChatMessage
	{
        public string MessageText { get; set; }
        public MessageOwner Owner  { get; set; }
    }
}

