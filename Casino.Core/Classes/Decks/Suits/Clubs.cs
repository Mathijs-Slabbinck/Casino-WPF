using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Core.Classes.Decks.Suits
{
    public class Clubs
    {
        private readonly string suitName = "Clubs";
        private readonly string suitNameShort = "C";
        private readonly string suitNameUnicode = "♣";
        private readonly string color = "Black";

        public string SuitName
        {
            get { return suitName; }
        }

        public string SuitNameShort
        {
            get { return suitNameShort; }
        }

        public string SuitNameUnicode
        {
            get { return suitNameUnicode; }
        }

        public string Color
        {
            get { return color; }
        }


    }
}
