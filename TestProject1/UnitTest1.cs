using KonsolaPojazdy4d;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            Samochod auto = new Samochod("xyz", 1234, 12);
            double wartoscOczekiwana = 500;
            int dni = 5;
            //Act
            double wynik = auto.ObliczKosztWynajmu(dni);
            //Assert
            Assert.AreEqual(wartoscOczekiwana, wynik, 0.0);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            Motocykl moto = new Motocykl(false ,"xyz", 1234);
            double wartoscOczekiwana = 700;
            int dni = 10;
            //Act
            double wynik = moto.ObliczKosztWynajmu(dni);
            //Assert
            Assert.AreEqual(wartoscOczekiwana, wynik, 0.0);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            Motocykl moto = new Motocykl(true, "xyz", 1234);
            double wartoscOczekiwana = 840;
            int dni = 10;
            //Act
            double wynik = moto.ObliczKosztWynajmu(dni);
            //Assert
            Assert.AreEqual(wartoscOczekiwana, wynik, 0.0);
        }
    }
}