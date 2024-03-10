using System;
namespace Bot_event_handler
{
	public class Channel
	{
		public string Name { get; set; }
		public List<Message> Messages { get; set; }

        public event EventHandler<PostArgs> OnPost;

        public Channel(string name, Server server)
        {
            Name = name;
            Messages = new List<Message>();
            server.Channels.Add(this);
        }

        public void Post(Message message)
        {
            Messages.Add(message);

            PostArgs postArgs = new PostArgs(this, message);
            OnPost?.Invoke(this, postArgs);
        }

        public void DisplayMessages()
        {
            foreach (Message message in Messages)
            {
                Console.WriteLine(message);
                Console.WriteLine();
            }


        }
    }
}

