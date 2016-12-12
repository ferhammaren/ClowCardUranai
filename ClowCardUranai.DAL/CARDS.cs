using System.IO;
using System.Linq;
/// <summary>
/// ferhammaren 2014
/// Class for reading Card information and spreads
/// </summary>
namespace ClowCardUranai.DAL
{
    public class CARDS
    {
        private static string cardList = "Resources/cardList.dat";
        /// <summary>
        /// Gets the data of the card indicated by the cardNumber parameter
        /// </summary>
        /// <param name="cardNumber"></param>
        /// <returns>cardData, an array of strings with the name, meanings and image of the card</returns>
        public static string[] getCardData(int cardNumber)
        {
            string line = "";
            string[] cardData = new string[4];
            line = File.ReadLines(cardList).Skip(cardNumber-1).Take(1).First();
            cardData=line.Split('|');
            return cardData;
        }
        public static void getSavedSpread(int spread) //can save in 5 spread slots
        {

        }
        public static void saveSpread(int spread) //can read 5 spread slots
        {

        }

    }
}
