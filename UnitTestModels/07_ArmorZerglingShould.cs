using Models.Armors;
using Models.Buildings;
using Models.Units;

namespace UnitTestModels
{
    public class ArmorZerglingShould
    {
        private readonly Zergling _zergling;

        public ArmorZerglingShould()
        {
            _zergling = new Zergling();
        }

        [Fact]
        public void WhenWithoutArmorShouldNotChangeDamage()
        {
            var damage = 10;

            var heealthExpected = _zergling.Health - damage ;
            _zergling.TakeDamage(damage);

            Assert.Equal(heealthExpected, _zergling.Health);
        }

        [Fact]
        public void WhenArmorBasicShouldDamageReduced2()
        {
            var damage = 10;
            var heealthExpected = _zergling.Health - (damage - 2);
            _zergling.TakeArmor(new BasicArmor());
            _zergling.TakeDamage(damage);
            Assert.Equal(heealthExpected, _zergling.Health);
        }

        [Fact]
        public void WhenArmorEnhancedShouldDamageDividedBy2()
        {
            var damage = 10;
            
            var heealthExpected = _zergling.Health - (damage / 2);
            _zergling.TakeArmor(new EnhancedArmor());
            _zergling.TakeDamage(damage);

            Assert.Equal(heealthExpected, _zergling.Health);
        }        
    }
}