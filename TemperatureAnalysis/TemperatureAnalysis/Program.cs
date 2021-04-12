using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TemperatureAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TemperatureModel> temperatureData = CsvReader.ReadFromCsv();

            var temperatureAnalyzer = new TemperatureAnalyzer();

            // Average temperature
            var averageTemp = temperatureAnalyzer.AverageTemperature(temperatureData);
            Console.WriteLine($"Average temperature during the period was {averageTemp} degrees");

            // Average day temperature
            var dayInterval = temperatureData.Where(x => (x.DateTime.Hour > 8 && x.DateTime.Hour < 17));
            var averageTempDay = temperatureAnalyzer.AverageTemperature(dayInterval.ToList());
            Console.WriteLine($"Average temperature during the DAY was {averageTempDay} degrees");

            // Average night temperature
            var nightInterval = temperatureData.Where(x => (x.DateTime.Hour > 17 || x.DateTime.Hour < 8));
            var averageTempNight = temperatureAnalyzer.AverageTemperature(nightInterval.ToList());
            Console.WriteLine($"Average temperature during the NIGHT was {averageTempNight} degrees");

            // Highest temperature
            var maxTemp = temperatureAnalyzer.MaxTemperature(temperatureData);
            var occurenceMax = temperatureAnalyzer.OccurenceTemperature(temperatureData, maxTemp);
            foreach (var occurence in occurenceMax)
            {
                Console.WriteLine($"Highest temperature: {maxTemp} occured {occurence.DateTime}");
            }

            // Lowest temperature
            var minTemp = temperatureAnalyzer.MinTemperature(temperatureData);
            var occurenceMin = temperatureAnalyzer.OccurenceTemperature(temperatureData, minTemp);
            foreach (var occurence in occurenceMin)
            {
                Console.WriteLine($"Lowest temperature: {minTemp} occured {occurence.DateTime}");
            }
        }
    }
}