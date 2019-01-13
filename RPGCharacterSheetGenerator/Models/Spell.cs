using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterSheetGenerator.Models
{
    public class Spell
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CastingNumber { get; set; }
        public string CastingTime { get; set; }
        public string Ingredient { get; set; }
        public string Description { get; set; }
    }
}
