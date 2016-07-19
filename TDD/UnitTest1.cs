using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeatherAssignment;

namespace TDD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetWeatherData()
        {
            WeatherDataServiceFactory obj = WeatherDataServiceFactory.Instance;

            CityWeather tmp = obj.GetWeatherDataService("London");                  //check if get worked
            Assert.IsNotNull(tmp);
        }

        [TestMethod]
        public void Test2GetWeatherData()
        {
            WeatherDataServiceFactory obj = WeatherDataServiceFactory.Instance;
            CityWeather tmp = obj.GetWeatherDataService("Lahore");                  //check if get worked
            Assert.IsNotNull(tmp);
        }
    }
}
