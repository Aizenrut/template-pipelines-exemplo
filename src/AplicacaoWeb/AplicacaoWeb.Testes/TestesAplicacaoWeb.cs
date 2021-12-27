using Xunit;

namespace AplicacaoWeb.Testes
{
    public class TestesAplicacaoWeb
    {
        [Fact]
        public void DeveRetornarTrue()
        {
            Assert.True(true);
        }

        [Fact]
        public void DeveRetornarTrueNovamente()
        {
            Assert.True(true);
        }

        [Fact]
        public void DeveRetornarTrueUmaUltimaVez()
        {
            Assert.True(true);
        }
    }
}
