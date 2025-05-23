using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Core.Classes.Decks.Suits;
using Casino.Core.interfaces;
using Windows.UI.Xaml.Media.Imaging;

namespace Casino.Core.Classes.Decks.Suits.Cards
{
    public class TwoOfHearts : Hearts, ICard
    {
        private readonly int value;
        private readonly BitmapImage image;
        private readonly BitmapImage bottomImage;
        private readonly string name = "Two of Hearts";
        private readonly string rank = "2";
        private readonly int rankValue = 2;

        public int Value
        {
            get { return value; }
        }

        public BitmapImage Image
        {
            get { return image; }
        }

        public BitmapImage BottomImage
        {
            get { return bottomImage; }
        }

        public string Name
        {
            get { return name; }
        }

        public string Rank
        {
            get { return rank; }
        }

        public int RankValue
        {
            get { return rankValue; }
        }

        public TwoOfHearts(int lvalue = 2)
        {
            value = lvalue;
            // we construct it when called so we are sure the xaml is loaded
            image = new BitmapImage(new Uri(@"Assets/cards/NotOnTable/" + Rank + "_of_" + SuitName + ".png", UriKind.RelativeOrAbsolute));
            bottomImage = new BitmapImage(new Uri(@"Assets/cards/OnTable/" + Rank + "_of_" + SuitName + ".png", UriKind.RelativeOrAbsolute));
        }

        public override string ToString()
        {
            return Name;
        }
    }
}