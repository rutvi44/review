using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last2
{

    public class PlayingCard
    {
        private string suit;
        private int value;

        public PlayingCard()
        {
            suit = "No suit";
            value = 0;
        }

        public PlayingCard(string suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

        public static bool IsValid(string suit, int value)
        {
            string[] validSuits = { "spade", "heart", "club", "diamond" };
            return Array.IndexOf(validSuits, suit.ToLower()) != -1 && value >= 1 && value <= 13;
        }

        public static void WriteToFile(List<PlayingCard> cards)
        {
            using (StreamWriter writer = new StreamWriter("xxPlayingCard.txt"))
            {
                foreach (PlayingCard card in cards)
                {
                    writer.WriteLine($"Suit: {card.suit}");
                    writer.WriteLine($"Value: {card.value}");
                    writer.WriteLine(); // Add an empty line between card entries
                }
            }
        }
    }

}
