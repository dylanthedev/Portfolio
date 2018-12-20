using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace MonsterLibrary
{
    public class Ogre : Monster
    {
        public bool IsArmored { get; set; }

        public Ogre(string name, int life, int maxLife, int hitChance,
            int block, int minDamage, int maxDamage, string description,
            bool isArmored)
            :base (name, life, maxLife, hitChance, block, minDamage, maxDamage,
                 description)
        {
            IsArmored = isArmored;
        }

        public override string ToString()
        {
            return base.ToString() + (IsArmored ? "It's wearing a thick suit of rusty," +
                "mismatched armour." : "It's wearing a bearskin loincloth.");
        }

        public override int CalcBlock()
        {
            int calculatedBlock = Block;

            if (IsArmored)
            {
                calculatedBlock += calculatedBlock / 2;
            }

            return calculatedBlock;
        }
    }
}
