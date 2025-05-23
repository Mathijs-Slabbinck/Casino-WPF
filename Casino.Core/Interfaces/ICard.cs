using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Casino.Core.interfaces
{
    public interface ICard
    {
        int Value { get; }
        BitmapImage Image { get; }
        BitmapImage BottomImage { get; }
        string Name { get; }
        string Rank { get; }
        String ToString();
    }
}
