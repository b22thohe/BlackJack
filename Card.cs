using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    // Store names of card types as Enum
    public enum CardColor { Diamonds, Clubs, Spades, Hearts}

    /// <summary>
    /// Class creates card for use in the game.
    /// Every card get a color and a value.
    /// </summary>

    public class Card
    {
        // Fields for storing card color and value.
        // FaceValue is used to get the correct filename for card images
        public CardColor Color { get; set; }
        public int CardValue { get; set; }
        public int FaceValue { get; set; }

        // Since it is set as static, the same random object will be used for entire game
        private static Random rnd = new Random();

        
        // Constructor
        public Card(CardColor color, int faceValue) { 
            this.Color = color;
            
                // All dressed cards will get 10 as CardValue, but different value for
                // FaceValue to be able to retrieve correct image
                switch (faceValue) { 
                    case 11:
                        this.CardValue = 10;
                        this.FaceValue = 11;
                        break;
                    case 12:
                        this.CardValue = 10;
                        this.FaceValue = 12;
                        break;
                    case 13:
                        this.CardValue = 10;
                        this.FaceValue = 13;
                        break;
                    default:
                        this.CardValue = faceValue;
                        this.FaceValue = faceValue;
                        break;
                }
        }

        // Method returns correct filename for card image.
        // File name format: color_value
        public string ImageFileName
        {
            get
            {
                string valuetext;
                if (FaceValue == 1)
                {
                    valuetext = "A";
                }
                else if (FaceValue == 11)
                {
                    valuetext = "J";
                }
                else if (FaceValue == 12)
                {
                    valuetext = "Q";
                }
                else if (FaceValue == 13)
                {
                    valuetext = "K";
                }
                else
                {
                    valuetext = CardValue.ToString();
                }

                return $"{Color.ToString().ToLower()}_{valuetext}.png";
            }
        }

        /**
         * Method takes player's list of cards and calculates sum of total value of cards in list
         * **/
        public static int Sum(List<Card> cards)
        {
            int result = 0;
            foreach (var card in cards)
            {
                result += card.CardValue;
            }
            return result;
        }

        /**
         * Method calls constructor with randomized parameters
         * **/
        public static Card RandomCard()
        {
            return new Card((CardColor)rnd.Next(0, 3), rnd.Next(1, 14));
        }
    }
}
