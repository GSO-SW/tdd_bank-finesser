namespace Banktests { 
    using Bank;
    

    [TestClass]
    public class KontoTests
    {
        [TestMethod]
        public void Einzahlen_GuthabenErhöhen()
        {
            //Arrange
            int startguthaben = 19;
            int einzahlung = 10;
            Konto k1 = new Konto(startguthaben);

            int guthaben_soll = startguthaben + einzahlung;

            //Act
            k1.Einzahlen(einzahlung);

            //Assert
            Assert.AreEqual(guthaben_soll, k1.Guthaben);

        }
    }
}