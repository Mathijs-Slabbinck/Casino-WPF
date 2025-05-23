using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casino.Core.Classes.Decks.Suits;
using Casino.Core.interfaces;
using Casino.Core.Interfaces;
using Windows.UI.Xaml.Media.Imaging;

namespace Casino.Core.Classes.Chips
{
    public class Chip50 : IChip
    {
        private readonly BitmapImage image;
        private readonly BitmapImage bottomImage;
        private readonly string name = "Chip50";
        private readonly int value = 50;
        private int amount;

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

        public int Value
        {
            get { return value; }
        }

        public int Amount
        {
            get { return amount; }
            set
            {
                if (amount + value < 0)
                {
                    throw new ArgumentOutOfRangeException("You don't have any of this kind of chip (left)!");
                }
                amount = value;
            }
        }

        public Chip50()
        {
            // we construct it when called so we are sure the xaml is loaded
            image = new BitmapImage(new Uri(@"Assets/chips/notOnTable/Chip50.png", UriKind.RelativeOrAbsolute));
            bottomImage = new BitmapImage(new Uri(@"Assets/onTable/chips/Chip50.png", UriKind.RelativeOrAbsolute));
        }
    }
}
