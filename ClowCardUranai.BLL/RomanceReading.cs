using ClowCardUranai.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClowCardUranai.BLL
{
    public class RomanceReading:Spread
    {
        public new string spreadName = "Romance Reading";
        public new string spreadDescription = "For when have a question about love";
        public const string CARD1 = "The liked/loved person's personality and true nature";
        public const string CARD2 = "The liked/loved person's and the questioner's past";
        public const string CARD3 = "The liked/loved person and the questioner's present situation";
        public const string CARD4 = "The liked/loved person and the questioner's future";
        public const string CARD5 = "The problem you must overcome in order to get along well with the liked/loved person";
        public const string CARD6 = "The result of the liked/loved person and the questioner's romance";
        public const string CARD7 = "Advice for a good relationship";
        private ClowCard[] spreadCards = new ClowCard[8];

        public RomanceReading()
        {

        }

        public override void fillCardList(int[] list)
        {
            ClowCard lastCard,firstCard;
            int cardCounter = 10;
            firstCard = createCard(list[0]);
            spreadCards[0] = firstCard;
            for (int a = 1; a < 7; a++)
            {
                ClowCard card = createCard(list[cardCounter]);
                spreadCards[a] = card;
                cardCounter = cardCounter + 10;
            }
            lastCard = createCard(list[list.Length]);
            spreadCards[8] = lastCard;
        }
    }
}
