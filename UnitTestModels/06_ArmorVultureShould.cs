using Models.Armors;
using Models.Buildings;
using Models.Units;

namespace UnitTestModels
{
    public class ArmorVultureShould
    {
        private readonly Vulture _vulture;


        public ArmorVultureShould()
        {
            _vulture = new Vulture();
        }

        [Fact]
        public void WhenWithoutArmorShouldNotChangeDamage()
        {
            var damage = 10;

            var heealthExpected = _vulture.Health - damage ;
            _vulture.TakeDamage(damage);

            Assert.Equal(heealthExpected, _vulture.Health);
        }

        [Fact]
        public void WhenArmorBasicShouldDamageReduced2()
        {
            var damage = 10;
            var heealthExpected = _vulture.Health - (damage - 2);
            _vulture.TakeArmor(new BasicArmor());
            _vulture.TakeDamage(damage);
            Assert.Equal(heealthExpected, _vulture.Health);
        }

        [Fact]
        public void WhenArmorEnhancedShouldDamageDividedBy2()
        {
            var damage = 10;
            
            var heealthExpected = _vulture.Health - (damage / 2);
            _vulture.TakeArmor(new EnhancedArmor());
            _vulture.TakeDamage(damage);

            Assert.Equal(heealthExpected, _vulture.Health);
        }        
    }
}