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
        public WarhammerSerachItemMenu()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void Exitlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MainWindow MW = new MainWindow();
            MW.Show();
            this.Close();
        }

        private void Topbuttonlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WarhammerItemSearchPage WISP = new WarhammerItemSearchPage();
            WISP.Show();
            this.Close();
        }

        private void TopBtn_Click(object sender, RoutedEventArgs e)
        {
            WarhammerItemSearchPage WISP = new WarhammerItemSearchPage();
            WISP.Show();
            this.Close();
        }
    }
}
