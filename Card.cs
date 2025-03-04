using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public enum CardColor { Diamonds, Clubs, Spades, Hearts}

    public class Card
    {
        public CardColor Color { get; set; }
        public int CardValue { get; set; }
        public int FaceValue { get; set; }
        private static Random rnd = new Random();

        
        // Constructor
        public Card(CardColor color, int faceValue) { 
            this.Color = color;

            
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

        public static int Sum(List<Card> cards)
        {
            int result = 0;
            foreach (var card in cards)
            {
                result += card.CardValue;
            }
            return result;
        }

        public static Card RandomCard()
        {
            return new Card((CardColor)rnd.Next(0, 3), rnd.Next(1, 14));
        }
    }
}
