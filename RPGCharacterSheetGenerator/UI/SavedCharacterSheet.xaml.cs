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
    /// Interaction logic for SavedCharacterSheet.xaml
    /// </summary>
    public partial class SavedCharacterSheet : Window
    {
        public SavedCharacterSheet()
        {
            InitializeComponent();
            if (System.IO.File.Exists("file.txt"))
            {
                string xaml = System.IO.File.ReadAllText("file.txt");
                object content = System.Windows.Markup.XamlReader.Parse(xaml);
                this.Content = content;
            }
        }
    }
}
