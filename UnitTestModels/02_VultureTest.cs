using Models.Units;

namespace UnitTestModels
{
    public class VultureTest : IDisposable
    {
        private readonly Vulture _vulture;
        private readonly StringWriter _sw;

        public VultureTest()
        {
            _vulture = new Vulture();
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
            Assert.Equal(60, _vulture.Health);
        }

        [Fact]
        public void Have5InSpeed()
        {
            Assert.Equal(10, _vulture.Speed);
        }

        [Fact]
        public void HaveScreamArgWhenDying()
        {
            _vulture.TakeDamage(60);
            Assert.Equal("BOOOOM!!!", _sw.ToString());
            Assert.Equal(0, _vulture.Health);
        }
    }
}