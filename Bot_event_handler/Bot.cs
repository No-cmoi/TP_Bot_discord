using System;
namespace Bot_event_handler
{
    public abstract class Bot : User
    {

        public Dictionary<string, EventHandler<PostArgs>> Commands { get; set; }

        public Bot(string nickName) : base(nickName)
        {
            Commands = new Dictionary<string, EventHandler<PostArgs>>();
        }

        public void BotAction(object? sender, PostArgs postArgs)
        {
            if (Commands.ContainsKey(postArgs.Message.Content))
            {
                EventHandler<PostArgs> botAction = Commands[postArgs.Message.Content];
                botAction(sender, postArgs);
            }
        }
    }
}

