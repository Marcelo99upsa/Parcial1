using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialMarceloOrtiz.Controllers;

namespace UnitTestCountry
{
    [TestClass]
    public class UnitTestParcial1
    {
        [TestMethod]
        public void TestGetCountry()
        {
            //Arrange
            CountriesController countriesController = new CountriesController();
            //Act
            var pruebacountry = countriesController.GetCountries();
            //Assert
            Assert.IsNotNull(GetCountries);
        }
    }
}
