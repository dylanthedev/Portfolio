using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Weapon
    {
        //fields
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitDamage;
        private bool _isTwoHanded;

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }//end Name

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }//end MaxDamage

        public int BonusHitDamage
        {
            get { return _bonusHitDamage; }
            set { _bonusHitDamage = value; }
        }//end BonusHitDamage

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }//end IsTwoHanded

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                //MinDamage can't be more than MaxDamage and cannot be less than 1
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }//end if
                else
                {
                    _minDamage = 1;
                }//end else
            }//end set
        }//end MinDamage



        //ctors
        public Weapon(string name, int minDamage, int maxDamage, 
            int bonusHitDamage, bool isTwoHanded)
        {
            //If you have any dependencies in your assignments
            //the dependant properties must be set after the
            //properties that they depend upon.
            Name = name;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            BonusHitDamage = bonusHitDamage;
            IsTwoHanded = isTwoHanded;
        }//end FQCTOR

        //methods
        public override string ToString()
        {
            return string.Format("{0}\nDamage: {1}-{2}\nCritical Hit: {3}%",
                Name,
                MinDamage,
                MaxDamage,
                BonusHitDamage,
                IsTwoHanded ? "Two-handed" : "One-handed");
        }
    }
}
