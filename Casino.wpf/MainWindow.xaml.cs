using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Casino.wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        #region event handlers

        private void ImgOpenChipsMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenChipsMenu();
        }

        private void ImgCloseChipsMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            CloseChipsMenu();
        }

        #endregion


        private void OpenChipsMenu()
        {
            imgOpenChipsMenu.Visibility = Visibility.Collapsed;
            vwbChipsMenu.Visibility = Visibility.Visible;
        }

        private void CloseChipsMenu()
        {
            vwbChipsMenu.Visibility = Visibility.Collapsed;
            imgOpenChipsMenu.Visibility = Visibility.Visible;
            
        }
    }
}