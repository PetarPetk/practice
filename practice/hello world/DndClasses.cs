

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hello_world
{
    class DndClasses
    {
        public int speed = 30;
        public virtual void Die()
        {
            Console.WriteLine("Your character has died!");
        }
        
        public void LevelUp()
        {
            Console.WriteLine("DING! Your character has leveled up!");
        }

        public void LongRest()
        {
            Console.WriteLine("Your characer is taking a long rest.");
        }

        public virtual void Move()
        { 
        
        }
    }
    class RogueClass : DndClasses
    {
        public String className = "Rogue";
        public override void Move()
        {
            Console.WriteLine("The rogue is moving!");
        }

    }

    class PaladinClass : DndClasses
    {
        public String className = "Paladin";
        public override void Die()
        {
            Console.WriteLine("PALADIN GOES BRRRRRT NO KILL! HE RESURRECT");
        }
        public override void Move()
        {
            Console.WriteLine("The paladin is moving!");
        }
    }

    class BardClass : DndClasses 
    {
        public String className = "Bard";
        public override void Move()
        {
            Console.WriteLine("The bard is moving!");
        }
    }

}

