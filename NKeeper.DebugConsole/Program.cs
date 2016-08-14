using System;
using System.Linq;

namespace NKeeper.DebugConsole
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var client = NKeeperClient.CreateAsync().GetAwaiter().GetResult();
            Console.WriteLine(client.Cards.Count());

            while (true)
            {
                var cardName = Console.ReadLine();
                if (cardName == "exit")
                {
                    break;
                }

                var card = client
                    .Cards
                    .Where(c => string.Compare(c.Name, cardName, StringComparison.CurrentCultureIgnoreCase) == 0)
                    .FirstOrDefault();

                if (card == null)
                {
                    Console.WriteLine("Couldn't find it.");
                }
                else
                {
                    Console.WriteLine(card.Text);
                    Console.WriteLine(card.PlayerClass.ToString());
                    Console.WriteLine(card.Type.ToString());
                    Console.WriteLine(client.GetCardImageUrl(card));
                }
            }
        }
    }
}