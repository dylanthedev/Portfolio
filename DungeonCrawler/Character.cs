using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    
        /*
         * The abstract modifier indicates that the thing being modified has
         * an incomplete implementation. It can be used with classes, methods
         * and properties. Use the abstract modifier in a class declaration to
         * indicate that the class is intended to be a base (parent) class
         * for other classes.
         */

    public abstract class Character
    {
        //fields
        private int _life;
        //properties
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                _life = value <= MaxLife ? value : MaxLife;
            }//end set
        }//end Life
         //ctors
         //This class is abstract. You can never instantiate an object from
         //it. Therefore, a ctor is unnecessary.

         //methods
         public virtual int CalcBlock()
         {
            return Block;
         }

         public virtual int CalcHitChance()
         {
            return HitChance;
         }

        public virtual int CalcDamage()
        {
            return 0;
        }

            
    }//end class
}//end namespace
