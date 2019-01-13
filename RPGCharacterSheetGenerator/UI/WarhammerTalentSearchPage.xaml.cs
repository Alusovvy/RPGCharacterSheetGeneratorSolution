using RPGCharacterSheetGenerator.DAL;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for WarhammerTalentSearchPage.xaml
    /// </summary>
    public partial class WarhammerTalentSearchPage : Window
    {
        MainWindow MW = new MainWindow();
        public WarhammerTalentSearchPage()
        {
            InitializeComponent();
            TalentDAL tDAL = new TalentDAL();
            DataTable dt = tDAL.Select();
            dgvTalents.ItemsSource = dt.DefaultView;
        }

        private void Exitlbl_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            MW.Show();
            this.Close();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            MW.Show();
            this.Close();
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string keyword = txbSearch.Text;
            TalentDAL tDAL = new TalentDAL();
            DataTable dt = tDAL.Search(keyword);
            dgvTalents.ItemsSource = dt.DefaultView;
        }

        private void GetItem(int id)
        {
            TalentDAL tDAL = new TalentDAL();
            DataTable dt = tDAL.SelectById(id);
            txbName.Content = dt.Rows[0]["name"].ToString();
            txbDescription.Content = dt.Rows[0]["description"].ToString();
            txbBonus.Content = dt.Rows[0]["bonus"].ToString();
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(txbItemId.Text);
            GetItem(id);
        }
    }
}
