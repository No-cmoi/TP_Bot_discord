using System;
namespace Bot_event_handler
{
	public class User
	{
		public string NickName { get; set; }
		public List<Channel> Channels { get; set; }
        public List<Server> Servers { get; set; }

        public User(string nickName)
        {
            NickName = nickName;
            Channels = new List<Channel>();
            Servers = new List<Server>();
        }
    }
}

