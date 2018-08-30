using Moq;
using PresaAppuntamenti.Entities;
using System;
using Xunit;

namespace PresaAppuntamentiTest.Entities
{
    public class ZonaTests : IDisposable
    {
        private MockRepository mockRepository;



        public ZonaTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private Zona CreateZona()
        {
            return new Zona();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var unitUnderTest = CreateZona();
            unitUnderTest.IdZona = "Toscana";
            unitUnderTest.Provincia = "Arezzo";

            // Act

            // Assert
            Assert.Equal("Toscana", unitUnderTest.IdZona);
            Assert.Equal("Arezzo", unitUnderTest.Provincia);
        }

    }
}
