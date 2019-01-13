using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCharacterSheetGenerator.Repos
{
    public class BasicSkills
    {
        public int RollSkill(string race, string skill)
        {
            int raceBonus = 0;
            if (race == "dwarf")
            {
                if(skill == "fellowship" || skill == "agility")
                {
                    raceBonus = -10;
                }
                if(skill == "weaponSkill" || skill == "toughness")
                {
                    raceBonus = 10;
                }
            }

            if ( race == "elf" )
            {
                if(skill == "ballisticSkill" || skill == "agility")
                {
                    raceBonus = 10;
                }
            }
            if (race == "halfling")
            {
                if (skill == "ballisticSkill" || skill == "agility" || skill == "fellowship")
                {
                    raceBonus = 10;
                }
            }
            Random random = new Random();
            int rolledSkill = (random.Next(1,10)+random.Next(1,10)+20) + raceBonus;

            return rolledSkill;
        }
    }
}
