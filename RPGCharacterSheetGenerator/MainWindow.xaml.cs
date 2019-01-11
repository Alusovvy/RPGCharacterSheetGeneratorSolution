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
        WarhammerMainSheetWindow WMSW = new WarhammerMainSheetWindow();
        WarhammerSerachItemMenu WSIM = new WarhammerSerachItemMenu();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Topbuttonlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WMSW.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WMSW.Show();
            this.Close();
        }

        private void Bottombuttonlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WSIM.Show();
            this.Close();
        }

        private void BottomBtn_Click(object sender, RoutedEventArgs e)
        {
            WSIM.Show();
            this.Close();
        }
    }
}
