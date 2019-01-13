using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RPGCharacterSheetGenerator.UI
{
    /// <summary>
    /// Interaction logic for WarhammerSerachItemMenu.xaml
    /// </summary>
    public partial class WarhammerSerachItemMenu : Window
    {
        WarhammerItemSearchPage WISP = new WarhammerItemSearchPage();
        MainWindow MW = new MainWindow();
        WarhammerTalentSearchPage WTSP = new WarhammerTalentSearchPage();
        WarhammerSpellSearchPage WSSP = new WarhammerSpellSearchPage();

        public WarhammerSerachItemMenu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MW.Show();
            this.Close();
        }

        private void Exitlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            MW.Show();
            this.Close();
        }

        private void Topbuttonlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            
            WISP.Show();
            this.Close();
        }

        private void TopBtn_Click(object sender, RoutedEventArgs e)
        {
            WISP.Show();
            this.Close();
        }

        private void MiddleBtn_Click(object sender, RoutedEventArgs e)
        {
            WTSP.Show();
            this.Close();
        }

        private void Middlebuttonlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WTSP.Show();
            this.Close();
        }

        private void Bottombuttonlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WSSP.Show();
            this.Close();
        }

        private void BottomBtn_Click(object sender, RoutedEventArgs e)
        {
            WSSP.Show();
            this.Close();
        }
    }
}
