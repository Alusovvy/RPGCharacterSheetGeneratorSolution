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
        }

    }
}
