using Moq;
using PresaAppuntamenti.Entities;
using System;
using Xunit;

namespace PresaAppuntamentiTest.Entities
{
    public class AgenteTests : IDisposable
    {
        private MockRepository mockRepository;



        public AgenteTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private Agente CreateAgente()
        {
            return new Agente();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var unitUnderTest = CreateAgente();

            // Act

            // Assert
            Assert.False(false);
        }

    }
}
