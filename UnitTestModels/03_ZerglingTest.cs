using Models.Units;

namespace UnitTestModels
{
    public class ZerglingTest : IDisposable
    {
        private readonly Zergling _zergling;
        private readonly StringWriter _sw;

        public ZerglingTest()
        {
            _zergling = new Zergling();
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
            Assert.Equal(30, _zergling.Health);
        }

        [Fact]
        public void Have5InSpeed()
        {
            Assert.Equal(7, _zergling.Speed);
        }

        [Fact]
        public void HaveScreamArgWhenDying()
        {
            _zergling.TakeDamage(30);
            Assert.Equal("SPLOTCH!!!", _sw.ToString());
            Assert.Equal(0, _zergling.Health);
        }
    }
}