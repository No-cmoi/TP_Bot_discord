using System;
namespace Bot_event_handler
{
	public class Message
	{
		public string Content { get; set; }
		public DateTime Date { get; set; }
        public User User { get; set; }
        

        public Message(string content, User user, Channel channel)
        {
            Content = content;
            Date = DateTime.Now;
            User = user;
            channel.Post(this);
            
        }

        public override string ToString()
        {
            return User.NickName + "\t" + Date + "\n" + Content; 
        }

    }
}

