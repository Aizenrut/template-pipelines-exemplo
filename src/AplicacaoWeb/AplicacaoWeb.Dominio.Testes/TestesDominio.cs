using Xunit;

namespace AplicacaoWeb.Dominio.Testes
{
    public class TestesDominio
    {
        [Fact]
        public void DeveRetornarFalse()
        {
            Assert.False(false);
        }

        [Fact]
        public void DeveRetornarFalseNovamente()
        {
            Assert.False(false);
        }

        [Fact]
        public void DeveRetornarFalseUmaUltimaVez()
        {
            Assert.False(false);
        }
    }
}
