using Moq;
using PresaAppuntamenti.Entities;
using System;
using Xunit;

namespace PresaAppuntamentiTest.Entities
{
    public class AgendaAgenteTests : IDisposable
    {
        private MockRepository mockRepository;



        public AgendaAgenteTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private AgendaAgente CreateAgendaAgente()
        {
            return new AgendaAgente();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var unitUnderTest = CreateAgendaAgente();

            // Act

            // Assert
            Assert.False(false);
        }

    }
}
