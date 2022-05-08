using System;
using AnnoChat.Models;

namespace AnnoChat.Views.Chat
{
	public class ChatMessageDataTemplateSelector : DataTemplateSelector
	{
		public DataTemplate ReceivedMessageTemplate { get; set; }
		public DataTemplate SentMessageTemplate { set; get; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            ChatMessage message = item as ChatMessage;

            if (message.Owner == MessageOwner.CurrentUser)
                return SentMessageTemplate;
            else
                return ReceivedMessageTemplate;
        }
    }
}

