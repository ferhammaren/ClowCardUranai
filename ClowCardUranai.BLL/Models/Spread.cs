using ClowCardUranai.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClowCardUranai.BLL.Models
{
    public abstract class Spread
    {
        public string spreadName { get; set; }
        public string spreadDescription{get;set;}
        public int cardQuantity { get; set; }
        List<ClowCard> cardList;

        //public static ClowCard getCard(int number)
        //{
        //    CARDS.getCard(number);
        //}
        public static ClowCard createCard(int cardNumber)
        {
            ClowCard card;
            string[] cardData;
            cardData=CARDS.getCardData(cardNumber);
            card = new ClowCard(cardData[0], cardData[1], cardData[2], cardData[3]);
            return card;
        }

        /// <summary>
        /// The filled list will be according to the rules of the spread
        /// </summary>
        /// <param name="cards"></param>
        public abstract void fillCardList(ClowCard[] cards);

    }
}
