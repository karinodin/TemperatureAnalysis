using System;
using System.Collections.Generic;
using System.IO;

namespace TemperatureAnalysis
{
    public class CsvReader
    {
        public static List<TemperatureModel> ReadFromCsv()
        {
            var path = "/Users/karinodin/CodeIsKing2021/TemperatureAnalysis/temperatures.csv";
            var file = File.ReadAllLines(path);
            
            List<TemperatureModel> temperatureData = new List<TemperatureModel>();

            foreach (var row in file)
            {
                var oneLine = row.Split(";");
                var id = Int32.Parse(oneLine[0]);
                var temperature = double.Parse(oneLine[1]);
                var dateTime = DateTime.Parse(oneLine[2]);

                temperatureData.Add(new TemperatureModel(id, temperature, dateTime));
            }

            return temperatureData;
        }
    }
}