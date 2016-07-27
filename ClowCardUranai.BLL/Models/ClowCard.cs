namespace ClowCardUranai.BLL.Models
{
    /// <summary>
    /// Model class for Clow cards
    /// </summary>
    public class ClowCard
    {
        string cardName { get; set; }
        string meaning1 { get; set; }
        string meaning2 { get; set; }
        string picture { get; set; }
        /// <summary>
        /// Constructor for Clow Cards
        /// </summary>
        /// <param name="cardName">Name of the card</param>
        /// <param name="meaning1">First meaning</param>
        /// <param name="meaning2">Second meaning</param>
        /// <param name="picture">Picture path url</param>
        public ClowCard(string cardName,string meaning1, string meaning2, string picture)
        {
            this.cardName = cardName;
            this.meaning1 = meaning1;
            this.meaning2 = meaning2;
            this.picture = picture;
        }
        /// <summary>
        /// Empty constructor for Clow Cards
        /// </summary>
        public ClowCard()
        {
            
        }

        public string drawCardBack()
        {
            //draw the card's back pattern
            return "";
        }
    }
}
