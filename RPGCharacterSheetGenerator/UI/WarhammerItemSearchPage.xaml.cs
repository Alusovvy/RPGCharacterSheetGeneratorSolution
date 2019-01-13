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
    /// Interaction logic for WarhammerItemSearchPage.xaml
    /// </summary>
    public partial class WarhammerItemSearchPage : Window
    {
        MainWindow MW = new MainWindow();
        public WarhammerItemSearchPage()
        {
            InitializeComponent();
            ItemDAL iDAL = new ItemDAL();
            DataTable dt = iDAL.Select();
            dgvItems.ItemsSource = dt.DefaultView;
        }

        private void TxbSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txbSearch.Text == "")
            {
                ItemDAL iDAL = new ItemDAL();
                DataTable dt = iDAL.Select();
                dgvItems.ItemsSource = dt.DefaultView;
            }
            else
            {
                string keyword = txbSearch.Text;
                ItemDAL iDAL = new ItemDAL();
                DataTable dt = iDAL.Search(keyword);
                dgvItems.ItemsSource = dt.DefaultView;
            }
        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(txbItemId.Text);
            GetItem(id);

        }

        private void GetItem(int id)
        {
            ItemDAL iDAL = new ItemDAL();
            DataTable dt = iDAL.SelectById(id);
            ItemName.Content = dt.Rows[0]["name"].ToString();
            Availability.Content = dt.Rows[0]["availability"].ToString();
            Enc.Content = dt.Rows[0]["enc"].ToString();
            Quality.Content = dt.Rows[0]["qualities"].ToString();
            Damage.Content = dt.Rows[0]["damage"].ToString();
            Range.Content = dt.Rows[0]["range"].ToString();
            Reload.Content = dt.Rows[0]["reload"].ToString();
            LocationCovered.Content = dt.Rows[0]["locationcovered"].ToString();
            AP.Content = dt.Rows[0]["ap"].ToString();
            Group.Content = dt.Rows[0]["grouptype"].ToString();
            Price.Content = dt.Rows[0]["price"].ToString();



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
    }
}
