using System;
namespace Bot_event_handler
{
	public class Server
	{
		public string Name { get; set; }
		public List<Channel> Channels { get; set; }
		public List<User> Users { get; set; }

        public Server(string name, User admin)
        {
            Name = name;
            Channels = new List<Channel>();
            Users = new List<User>();
            JoinServer(admin);
        }

        public void JoinServer(User user)
        {
            Users.Add(user);
            user.Servers.Add(this);
        }
    }
}

