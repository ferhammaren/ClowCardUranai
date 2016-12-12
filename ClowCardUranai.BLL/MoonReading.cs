using ClowCardUranai.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClowCardUranai.BLL
{
    public class MoonReading:Spread
    {
        public new string spreadName = "Moon Reading";
        public new string spreadDescription = "For when you want to ask a question about something other than love";
        public const string CARD1 = "The problem";
        public const string CARD2 = "How you now influence the concerned person(s)";
        public const string CARD3 = "What kind of influence you have on surrounding people";
        public const string CARD4 = "The key/key person to solving the problem";
        public const string CARD5 = "The result if the problem is settled well";
        public const string CARD6 = "The result if the problem is not settled well";
        public const string CARD7 = "The solution to the problem";
        private ClowCard[] spreadCards = new ClowCard[8];
        public MoonReading()
        {

        }

        public override void fillCardList(int[] list)
        {
            ClowCard lastCard;
            int cardCounter = 7;
            for (int a = 1; a < 7; a++)
            {
                ClowCard card = createCard(list[cardCounter]);
                spreadCards[a] = card;
                cardCounter = cardCounter + 7;
            }
            lastCard = createCard(list[list.Length]);
            spreadCards[8] = lastCard;
        }
    }
}
