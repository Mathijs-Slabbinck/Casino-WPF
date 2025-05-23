using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace Casino.Core.Interfaces
{
    public interface IChip
    {
        BitmapImage Image { get; }
        BitmapImage BottomImage { get; }
        string Name { get; }
        int Value { get; }
        int Amount { get; set; }
    }

}