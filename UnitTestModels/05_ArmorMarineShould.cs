using Models.Armors;
using Models.Buildings;
using Models.Units;

namespace UnitTestModels
{
    public class ArmorShould
    {
        private readonly Marine _marine;

        public ArmorShould()
        {
            _marine = new Marine();
        }

        [Fact]
        public void WhenWithoutArmorShouldNotChangeDamage()
        {
            var damage = 10;

            var heealthExpected = _marine.Health - damage ;
            _marine.TakeDamage(damage);

            Assert.Equal(heealthExpected, _marine.Health);
        }

        [Fact]
        public void WhenArmorBasicShouldDamageReduced2()
        {
            var damage = 10;
            var heealthExpected = _marine.Health - (damage - 2);
            _marine.SetArmor(new BasicArmor());
            _marine.TakeDamage(damage);
            Assert.Equal(heealthExpected, _marine.Health);
        }

        [Fact]
        public void WhenArmorEnhancedShouldDamageDividedBy2()
        {
            var damage = 10;
            
            var heealthExpected = _marine.Health - (damage / 2);
            _marine.SetArmor(new EnhancedArmor());
            _marine.TakeDamage(damage);

            Assert.Equal(heealthExpected, _marine.Health);
        }

        [Fact]
        public void WhenArmorMyticShouldDamageDividedBy2()
        {
            var damage = 10;

            var heealthExpected = _marine.Health - ((int)Math.Ceiling(damage * 0.25));
            _marine.SetArmor(new MysticArmor());
            _marine.TakeDamage(damage);

            Assert.Equal(heealthExpected, _marine.Health);
        }
    }
}