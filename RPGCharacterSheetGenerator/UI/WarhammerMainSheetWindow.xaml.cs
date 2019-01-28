using RPGCharacterSheetGenerator.Repos;
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
    /// Interaction logic for WarhammerMainSheetWindow.xaml
    /// </summary>
    public partial class WarhammerMainSheetWindow : Window
    {
        bool SkillsRolled = false;
        BasicSkills BS = new BasicSkills();
        public WarhammerMainSheetWindow()
        {
            InitializeComponent();
        }


        private void SkillRoll_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (cmbRace.Text == "")
            {
                MessageBox.Show("You need to chose the race first!");
            } else
            {
                RollBasicSkills();
            }
            

        }

        private void BtnSkillRoll_Click(object sender, RoutedEventArgs e)
        {
                        if (cmbRace.Text == "")
            {
                MessageBox.Show("You need to chose the race first!");
            } else
            {
                RollBasicSkills();
            }
        }

        public void RollBasicSkills()
        {
            sWS.Content = BS.RollSkill(cmbRace.Text, weaponSkill.Name.ToString()); ;
            MessageBox.Show("Your Weapon Skill is" + sWS.Content);
            sBS.Content = BS.RollSkill(cmbRace.Text, ballisticSkill.Name.ToString());
            MessageBox.Show("Your Balistic Skill is" + sBS.Content);
            sS.Content = BS.RollSkill(cmbRace.Text, strength.Name.ToString());
            MessageBox.Show("Your strength is" + sS.Content);
            sT.Content = BS.RollSkill(cmbRace.Text, toughness.Name.ToString());
            MessageBox.Show("Your toughness is" + sT.Content);
            sAg.Content = BS.RollSkill(cmbRace.Text, agility.Name.ToString());
            MessageBox.Show("Your agility is" + sAg.Content);
            sInt.Content = BS.RollSkill(cmbRace.Text, intelligence.Name.ToString());
            MessageBox.Show("Your intelligence is" + sInt.Content);
            sWP.Content = BS.RollSkill(cmbRace.Text, willpower.Name.ToString());
            MessageBox.Show("Your will power is" + sWP.Content);
            sFel.Content = BS.RollSkill(cmbRace.Text, fellowship.Name.ToString());
            MessageBox.Show("Your fellowship is" + sFel.Content);
            SkillsRolled = true;
        }


        private void A_Fel_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            int sum = Int32.Parse(sFel.Content.ToString());
            if (Int32.TryParse(A_Fel.Text, out int parsed) && SkillsRolled)
            {
                sum = Int32.Parse(sFel.Content.ToString()) + parsed;
                C_Fel.Content = sum.ToString();
            }
            else if (SkillsRolled)
            {
                
                MessageBox.Show("Use only numbers");
            }
            
        }

        private void A_WP_TextChanged(object sender, TextChangedEventArgs e)
        {
            int sum = Int32.Parse(sWP.Content.ToString());
            if (Int32.TryParse(A_WP.Text, out int parsed) && SkillsRolled)
            {
                sum = Int32.Parse(sWP.Content.ToString()) + parsed;
                C_WP.Content = sum.ToString();
            }
            else if (SkillsRolled)
            {

                MessageBox.Show("Use only numbers");
            }
        }

        private void A_Int_TextChanged(object sender, TextChangedEventArgs e)
        {
            int sum = Int32.Parse(sInt.Content.ToString());
            if (Int32.TryParse(A_Int.Text, out int parsed) && SkillsRolled)
            {
                sum = Int32.Parse(sInt.Content.ToString()) + parsed;
                C_Fel.Content = sum.ToString();
            }
            else if (SkillsRolled)
            {

                MessageBox.Show("Use only numbers");
            }
        }

        private void A_Ag_TextChanged(object sender, TextChangedEventArgs e)
        {
            int sum = Int32.Parse(sAg.Content.ToString());
            if (Int32.TryParse(A_Ag.Text, out int parsed) && SkillsRolled)
            {
                sum = Int32.Parse(sAg.Content.ToString()) + parsed;
                C_Ag.Content = sum.ToString();
            }
            else if (SkillsRolled)
            {

                MessageBox.Show("Use only numbers");
            }
        }

        private void A_T_TextChanged(object sender, TextChangedEventArgs e)
        {
            int sum = Int32.Parse(sT.Content.ToString());
            if (Int32.TryParse(A_T.Text, out int parsed) && SkillsRolled)
            {
                sum = Int32.Parse(sT.Content.ToString()) + parsed;
                C_T.Content = sum.ToString();
            }
            else if (SkillsRolled)
            {

                MessageBox.Show("Use only numbers");
            }
        }

        private void A_S_TextChanged(object sender, TextChangedEventArgs e)
        {
            int sum = Int32.Parse(sS.Content.ToString());
            if (Int32.TryParse(A_S.Text, out int parsed) && SkillsRolled)
            {
                sum = Int32.Parse(sS.Content.ToString()) + parsed;
                C_S.Content = sum.ToString();
            }
            else if (SkillsRolled)
            {

                MessageBox.Show("Use only numbers");
            }
        }

        private void A_BS_TextChanged(object sender, TextChangedEventArgs e)
        {
            int sum = Int32.Parse(sBS.Content.ToString());
            if (Int32.TryParse(A_BS.Text, out int parsed) && SkillsRolled)
            {
                sum = Int32.Parse(sBS.Content.ToString()) + parsed;
                C_BS.Content = sum.ToString();
            }
            else if (SkillsRolled)
            {

                MessageBox.Show("Use only numbers");
            }
        }

        private void A_WS_TextChanged(object sender, TextChangedEventArgs e)
        {
            int sum = Int32.Parse(sWS.Content.ToString());
            if (Int32.TryParse(A_WS.Text, out int parsed) && SkillsRolled)
            {
                sum = Int32.Parse(sWS.Content.ToString()) + parsed;
                C_WS.Content = sum.ToString();
            }
            else if (SkillsRolled)
            {

                MessageBox.Show("Use only numbers");
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string xaml = System.Windows.Markup.XamlWriter.Save(this.Content);
            System.IO.File.WriteAllText(txbName.Text + ".txt", xaml);
        }

        private void LblSave_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            string xaml = System.Windows.Markup.XamlWriter.Save(this.Content);
            System.IO.File.WriteAllText(txbName.Text+".txt", xaml);
        }
    }
}
