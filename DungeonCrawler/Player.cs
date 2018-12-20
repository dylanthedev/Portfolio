using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Player : Character
    {
        //fields
        //Because we are using automatic properties below, we only need
        //to create fields for properties that have business rules.
        //private int _life;


        //properties
        //public string Name { get; set; }
        //public int HitChance { get; set; }
        //public int Block { get; set; }
        //public int MaxLife { get; set; }
        public Race CharacterRace { get; set; }
        public Weapon EquippedWeapon { get; set; }

        //public int Life
        //{
        //    get { return _life; }
        //    set
        //    {
        //        _life = value <= MaxLife ? value : MaxLife;
        //    }//end set
        //}//end Life

        //ctors
        public Player(string name, int hitChance, int block, int life, int maxLife,
            Race characterRace, Weapon equippedWeapon)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
            CharacterRace = characterRace;
            EquippedWeapon = equippedWeapon;
        }

        //methods
        public override string ToString()
        {
            string description = "";

            switch (CharacterRace)
            {
                case Race.Dwarf:
                    description = "Short and stout.";
                    break;
                case Race.Gnome:
                    description = "Those weird things that sit on human's lawns.";
                    break;
                case Race.Elf:
                    description = "Pointy ears.";
                    break;
                case Race.Human:
                    description = "Powerless and weak.";
                    break;
                case Race.Khajiit:
                    description = "Here kitty kitty.";
                    break;
                case Race.Ork:
                    description = "A demon that lives in the mountains.";
                    break;
                case Race.Jedi:
                    description = "Lightsabers!";
                    break;
                case Race.Muggle:
                    description = "Powerless and weak.";
                    break;
                case Race.Halfling:
                    description = "A small person.";
                    break;
                case Race.Dwemer:
                    description = "People of the Deep.";
                    break;
                case Race.Daedra:
                    description = "Inhabitant of Tamriel.";
                    break;
                
            }//end switch

            return string.Format("Player Info:\n{0}\nLife: {1} of {2}\nHit Chance: {3}%\n" +
                "Weapon of choice: {4}\nBlock: {5}\nDescription: {6}\n",
                Name,
                Life,
                MaxLife,
                HitChance,
                EquippedWeapon,
                Block,
                description);
        }//end ToString()

        public override int CalcDamage()
        {
            Random rand = new Random();
            int damage = rand.Next(EquippedWeapon.MinDamage, EquippedWeapon.MaxDamage + 1);

            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + EquippedWeapon.BonusHitDamage;
        }
    }//end class
}//end namespace
