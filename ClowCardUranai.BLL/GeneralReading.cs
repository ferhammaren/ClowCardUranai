using ClowCardUranai.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClowCardUranai.BLL
{
    public class GeneralReading : Spread
    {
        public new string spreadName = "General Reading";
        public new string spreadDescription = "For when you want to answer a more general question";
        public const string CARD1 = "The problem";
        public const string CARD2 = "Cause of the problem";
        public const string CARD3 = "Past problems relating to the current problem";
        public const string CARD4 = "Surrounding circumstances of the problem";
        public const string CARD5 = "Solution to the problem";
        public const string CARD6 = "The solution's keyword";
        public const string CARD7 = "Obstacle to solving the problem";
        public const string CARD8 = "Future of the problem";
        public const string CARD9 = "End result";
        public const string CARD10 = "How others may see the problem";
        private ClowCard[] spreadCards = new ClowCard[10];
        public GeneralReading()
        {
          
        }

        /// <summary>
        /// Puts cards in the positions of the spread
        /// </summary>
        /// <param name="list">List of shuffled Clow Cards in number</param>
        public override void fillCardList(int[] list)
        {
            ClowCard lastCard;
            int cardCounter = 5;
            for(int a = 0; a < 9; a++)
            {
                ClowCard card = createCard(list[cardCounter]);
                spreadCards[a] = card;
                cardCounter = cardCounter + 5;
            }
            lastCard = createCard(list[list.Length]);
            spreadCards[9] = lastCard;
        }
    }
}
