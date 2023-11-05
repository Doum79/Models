using Models.Buildings;
using Models.Units;

namespace UnitTestModels
{
    public class BuilderSould
    {
        private readonly Builder _builder;

        public BuilderSould()
        {
            _builder = new Builder();
        }

        [Fact]
        public void BuildArmor()
        {
            var building = _builder.Build(BuildingType.Armory);
            Assert.Equal(BuildingType.Armory, building.Type);
        }

        [Fact]
        public void BuildBarracks()
        {
            var building = _builder.Build(BuildingType.Barracks);
            Assert.Equal(BuildingType.Barracks, building.Type);
        }

        [Fact]
        public void BuildCommandCenter()
        {
            var building = _builder.Build(BuildingType.CommandCenter);
            Assert.Equal(BuildingType.CommandCenter, building.Type);
        }
    }
}