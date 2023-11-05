using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armors
{
    public class MysticArmor : IArmor
    {
        public int UpdateDamage(int damage)
        {
            damage = (int)Math.Ceiling(damage * 0.25);
          
            if (damage < 0) damage = 0; return damage;
        }
    }
}
