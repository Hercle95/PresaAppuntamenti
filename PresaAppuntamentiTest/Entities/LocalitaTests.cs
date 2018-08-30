using Moq;
using PresaAppuntamenti.Entities;
using System;
using Xunit;

namespace PresaAppuntamentiTest.Entities
{
    public class LocalitaTests : IDisposable
    {
        private MockRepository mockRepository;



        public LocalitaTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        private Localita CreateLocalita()
        {
            return new Localita();
        }

        [Fact]
        public void TestMethod1()
        {
            // Arrange
            var unitUnderTest = CreateLocalita();
            unitUnderTest.Strada = "V. Generale";
            unitUnderTest.Civico = "45";
            unitUnderTest.Citta = "Arezzo";
            unitUnderTest.Provincia = "Arezzo";

            // Act

            // Assert
            Assert.Equal("V. Generale", unitUnderTest.Strada);
            Assert.Equal("45", unitUnderTest.Civico);
            Assert.Equal("Arezzo", unitUnderTest.Citta);
            Assert.Equal("Arezzo", unitUnderTest.Provincia);
        }

    }
}
