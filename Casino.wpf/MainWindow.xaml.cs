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
using Casino.Core;
using Casino.Core.Classes.Decks;
using Casino.Core.Classes.Decks.Suits.Cards;
using Casino.Core.Classes.Decks.Suits;
using Casino.Core.interfaces;
using Casino.Core.Classes.Chips;
using Casino.Core.Classes;

namespace Casino.wpf{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Player player;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            player = new Player();
            UpdateChipsInventoryInUI();
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

        private void UpdateChipsInventoryInUI()
        {
            lblChipOneAmount.Content = player.ChipInventory.IChip1.Amount;
            lblChipFiveAmount.Content = player.ChipInventory.IChip5.Amount;
            lblChipTenAmount.Content = player.ChipInventory.IChip10.Amount;
            lblChipTwentyAmount.Content = player.ChipInventory.IChip20.Amount;
            lblChipFiftyAmount.Content = player.ChipInventory.IChip50.Amount;
            lblChipHundredAmount.Content = player.ChipInventory.IChip100.Amount;
            lblChipFiveHundredAmount.Content = player.ChipInventory.IChip500.Amount;
            lblChipThousandAmount.Content = player.ChipInventory.IChip1000.Amount;
            lblChipFiveThousandAmount.Content = player.ChipInventory.IChip5000.Amount;
        }   
    }
}