using Moq;
using PresaAppuntamenti.Entities;
using System;
using Xunit;

namespace PresaAppuntamentiTest.Entities
{
    public class AppuntamentoTests : IDisposable
    {
        private MockRepository mockRepository;



        public AppuntamentoTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private Appuntamento CreateAppuntamento()
        {
            return new Appuntamento();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var unitUnderTest = CreateAppuntamento();

            // Act

            // Assert
            Assert.False(false);
        }

    }
}
