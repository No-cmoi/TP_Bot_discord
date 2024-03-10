using System;
namespace Bot_event_handler
{
	public class PostArgs : EventArgs
	{
		public Channel Channel { get; set; }
		public Message Message { get; set; }

        public PostArgs(Channel channel, Message message)
        {
            Channel = channel;
            Message = message;
        }
    }
}

