using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TemperatureAnalysis;

namespace Tests
{
    [TestClass]
    public class TestOfTemperatures
    {
        private TemperatureAnalyzer _temperatureAnalyzer;
        private List<TemperatureModel> _temperatureModels;
        
        [TestInitialize]
        public void TestFixture()
        {
            _temperatureAnalyzer = new TemperatureAnalyzer();

            _temperatureModels = new List<TemperatureModel>
            {
                new(1616035781, -1, new DateTime(2021, 03, 18)),
                new(1616035782, -0.5, new DateTime(2021, 03, 18)),
                new(1616035783, 0, new DateTime(2021, 03, 18)),
                new(1616035784, 0.5, new DateTime(2021, 03, 18)),
                new(1616035785, 1, new DateTime(2021, 03, 18)),
                new(1616035786, 1.5, new DateTime(2021, 03, 18)),
                new(1616035787, 2, new DateTime(2021, 03, 18))
            };
        }

        [TestMethod]
        public void Returns_Average_Temperature()
        {
            var expected = 0.5;
            var actual = _temperatureAnalyzer.AverageTemperature(_temperatureModels);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns_Highest_Temperature()
        {
            var expected = 2;
            var actual = _temperatureAnalyzer.MaxTemperature(_temperatureModels);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Returns_Lowest_Temperature()
        {
            var expected = -1;
            var actual = _temperatureAnalyzer.MinTemperature(_temperatureModels);
            Assert.AreEqual(expected, actual);
        }
    }
}