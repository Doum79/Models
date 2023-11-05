using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Armors
{
    public class BasicArmor : IArmor
    {
        public int UpdateDamage(int damage)
        {
            damage -= 2;

            if(damage < 0) damage = 0; return damage;
        }
    }
}
