﻿using RPGCharacterSheetGenerator.DAL;
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
    /// Interaction logic for WarhammerSpellSearchPage.xaml
    /// </summary>
    public partial class WarhammerSpellSearchPage : Window
    {
        MainWindow MW = new MainWindow();
        public WarhammerSpellSearchPage()
        {
            InitializeComponent();
            SpellDAL tDAL = new SpellDAL();
            DataTable dt = tDAL.Select();
            dgvSpells.ItemsSource = dt.DefaultView;
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
            SpellDAL tDAL = new SpellDAL();
            DataTable dt = tDAL.Search(keyword);
            dgvSpells.ItemsSource = dt.DefaultView;
        }

        private void GetItem(int id)
        {
            SpellDAL tDAL = new SpellDAL();
            DataTable dt = tDAL.SelectById(id);
            txbSpellName.Content = dt.Rows[0]["name"].ToString();
            txbCastingTime.Content = dt.Rows[0]["castingtime"].ToString();
            txbCastingNumber.Content = dt.Rows[0]["castingnumber"].ToString();
            txbIngredient.Content = dt.Rows[0]["ingredient"].ToString();
            txbDescription.Content = dt.Rows[0]["spelldescription"].ToString();


        }

        private void SelectBtn_Click(object sender, RoutedEventArgs e)
        {
            int id = Int32.Parse(txbItemId.Text);
            GetItem(id);
        }
    }
}
