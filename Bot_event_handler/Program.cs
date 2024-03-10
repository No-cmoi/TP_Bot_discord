namespace Bot_event_handler;

class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("Arnaud");
        User user2 = new User("Imane");
        Server MNS = new Server("MNS", user1);
        Channel channel1 = new Channel("CDA C#", MNS);
        Channel channel2 = new Channel("Divers", MNS);

        Bot bot1 = new BotDice("BotDédé");
        channel1.OnPost += bot1.BotAction;
        channel2.OnPost += bot1.BotAction;

        Message message1 = new Message("Salut tout le monde !", user1, channel1);
        Message message2 = new Message("Hey comment ça va ?", user2, channel1);
        Message message3 = new Message("!id6", user1, channel2);
        Message message4 = new Message("!id12", user1, channel2);


        channel1.DisplayMessages();
        channel2.DisplayMessages();
    }
}

