using RPGCharacterSheetGenerator.UI;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RPGCharacterSheetGenerator
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

        private void Topbuttonlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WarhammerMainSheetWindow WMSW = new WarhammerMainSheetWindow();
            WMSW.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WarhammerMainSheetWindow WMSW = new WarhammerMainSheetWindow();
            WMSW.Show();
            this.Close();
        }

        private void Bottombuttonlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WarhammerSerachItemMenu WSIM = new WarhammerSerachItemMenu();
            WSIM.Show();
            this.Close();
        }

        private void BottomBtn_Click(object sender, RoutedEventArgs e)
        {
            WarhammerSerachItemMenu WSIM = new WarhammerSerachItemMenu();
            WSIM.Show();
            this.Close();
        }

        private void MiddleBtn_Click(object sender, RoutedEventArgs e)
        {
            SavedCharacterSheet SCS = new SavedCharacterSheet();
            SCS.Show();
            this.Close();
        }
    }
}
