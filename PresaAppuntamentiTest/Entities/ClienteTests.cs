using Moq;
using PresaAppuntamenti.Entities;
using System;
using Xunit;

namespace PresaAppuntamentiTest.Entities
{
    public class ClienteTests : IDisposable
    {
        private MockRepository mockRepository;



        public ClienteTests()
        {
            this.mockRepository = new MockRepository(MockBehavior.Strict);


        }

        public void Dispose()
        {
            this.mockRepository.VerifyAll();
        }

        public Cliente CreateCliente()
        {
            return new Cliente();
        }

        [Fact]
        public void TestAttributes()
        {
            // Arrange
            var unitUnderTest = CreateCliente();
            unitUnderTest.Nome = "Matteo";
            unitUnderTest.Cognome = "Casini";
            unitUnderTest.SedeLegale = "V. Generale 45 Arezzo, Arezzo";
            unitUnderTest.SedeOperativa = "V. Generale 45 Arezzo, Arezzo";
            unitUnderTest.PIva = "00000000000";
            unitUnderTest.RagioneSociale = "Pelletteria";
            unitUnderTest.CodFiscale = "KKLLKK65D66S666S";
            unitUnderTest.NumeroTelefono = "0575111111";

            // Act

            // Assert
            Assert.Equal("Matteo", unitUnderTest.Nome);
            Assert.Equal("Casini", unitUnderTest.Cognome);
            Assert.Equal("V. Generale 45 Arezzo, Arezzo", unitUnderTest.SedeLegale);
            Assert.Equal("V. Generale 45 Arezzo, Arezzo", unitUnderTest.SedeOperativa);
            Assert.Equal("00000000000", unitUnderTest.PIva);
            Assert.Equal("Pelletteria", unitUnderTest.RagioneSociale);
            Assert.Equal("KKLLKK65D66S666S", unitUnderTest.CodFiscale);
            Assert.Equal("0575111111", unitUnderTest.NumeroTelefono);
        }
    }
}
