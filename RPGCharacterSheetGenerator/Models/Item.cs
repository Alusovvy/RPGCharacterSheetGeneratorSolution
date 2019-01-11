using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterSheetGenerator.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Enc { get; set; }
        public string GroupType { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
        public string Reload { get; set; }
        public string Qualities { get; set; }
        public string Availability { get; set; }
        public string LocationCovered { get; set; }
        public int AP { get; set; }
    }
}
