using Models.Units;

namespace UnitTestModels
{
    public class MarineTest : IDisposable
    {
        private readonly Marine _marine;
        private readonly StringWriter _sw;

        public MarineTest()
        {
            _marine = new Marine();
            _sw = new StringWriter();
            System.Console.SetOut(_sw);
        }
        
        public void Dispose()
        {
            _sw.Dispose();
        }

        [Fact]
        public void Have40InHealth()
        {
            Assert.Equal(40, _marine.Health);
        }

        [Fact]
        public void Have5InSpeed()
        {
            Assert.Equal(5, _marine.Speed);
        }

        [Fact]
        public void HaveScreamArgWhenDying()
        {
            _marine.TakeDamage(40);
            Assert.Equal("AAARGH!!!", _sw.ToString());
            Assert.Equal(0, _marine.Health);
        }
    }
}