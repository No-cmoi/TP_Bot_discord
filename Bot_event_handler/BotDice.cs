using System;
namespace Bot_event_handler
{
    public class BotDice : Bot
    {
        public BotDice(string nickName) : base(nickName)
        {
            Commands.Add("!id6", ThrowDice6);
            Commands.Add("!id12", Throwdice12);

            Commands.Add("Salut",
                (sender, postArgs) =>
                new Message("Salut", this, postArgs.Channel));
        }

        public void ThrowDice6(object? sender, PostArgs postArgs)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 7);

            Message message = new Message(randomNumber.ToString(), this, postArgs.Channel);
            //Console.WriteLine("le dé affiche un " + randomNumber);
        }

        public void Throwdice12(object? sender, PostArgs postArgs)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 13);
            Message message = new Message(randomNumber.ToString(), this, postArgs.Channel);
            //Console.WriteLine("le dé à 12 faces affiche un " + randomNumber);
        }
    }
}

