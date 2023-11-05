using Models.Armors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Units
{
    public class Zergling
    {
        public int Health { get; private set; } = 30;
        public int Speed { get; private set; } = 7;
        public IArmor Armor { get; private set; }

        public void TakeDamage(int damage)
        {
            if (Armor != null)
            {
                damage = Armor.UpdateDamage(damage);
            }
            Health -= damage;

            if (Health < 0) Health = 0;

            Console.Write("SPLOTCH!!!");



        }

        public void TakeArmor(IArmor armor)
        {
            Armor = armor;
        }
    }
}
