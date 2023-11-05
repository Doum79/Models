using Models.Armors;

namespace Models.Units
{
    public class Marine
    {
        public int Health { get; private set; } = 40;
        public int Speed { get; private set; } = 5;

        public IArmor Armor { get; private set; }
        public void TakeDamage(int damage)
        {
            if(Armor != null)
            {
                damage = Armor.UpdateDamage(damage);
            }


           Health -= damage;

            if(Health < 0) Health = 0;

            Console.Write("AAARGH!!!");
        }

        public void SetArmor(IArmor armor)
        {
            Armor = armor;
        }
        
    }
}
