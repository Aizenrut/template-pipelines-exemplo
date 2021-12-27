using Xunit;

namespace AplicacaoWeb.Integracao.Testes
{
    public class TestesIntegracao
    {
        [Fact]
        public void DeveSerNulo()
        {
            Assert.Null(null);
        }

        [Fact]
        public void DeveSerNuloNovamente()
        {
            Assert.Null(null);
        }

        [Fact]
        public void DeveSerNuloUmaUltimaVez()
        {
            Assert.Null(null);
        }
    }
}
