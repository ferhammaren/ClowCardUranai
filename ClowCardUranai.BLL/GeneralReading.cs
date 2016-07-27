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
        public const ConsoleCancelEventArgs
        public GeneralReading(int[] shuffledCards)
        {
            spreadName = "General Reading";
            spreadDescription = "For when you want to answer a more general question";
        }


        public override void fillCardList(ClowCard[] list)
        {

        }
    }
}
