using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClowCardUranai.BLL.Models
{
    class ClowCard
    {
        string cardName { get; set; }
        string meaning1 { get; set; }
        string meaning2 { get; set; }
        string picture { get; set; }

        public ClowCard(string cardName,string meaning1, string meaning2, string picture)
        {
            this.cardName = cardName;
            this.meaning1 = meaning1;
            this.meaning2 = meaning2;
            this.picture = picture;
        }
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
