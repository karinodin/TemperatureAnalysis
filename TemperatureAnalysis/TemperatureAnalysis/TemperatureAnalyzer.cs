using System;
using System.Collections.Generic;
using System.Linq;

namespace TemperatureAnalysis
{
    public class TemperatureAnalyzer
    {

        public double AverageTemperature(List<TemperatureModel> temperatureModels)
        {
            return temperatureModels.Select(x => x.Temperature).Average();
        }
        
        public double MaxTemperature(List<TemperatureModel> temperatureModels)
        {
            return temperatureModels.Select(x => x.Temperature).Max();
        }
        
        public double MinTemperature(List<TemperatureModel> temperatureModels)
        {
            return temperatureModels.Select(x => x.Temperature).Min();
        }

        public List<TemperatureModel> OccurenceTemperature(List<TemperatureModel> temperatureModels, double temperature)
        {
            var models = temperatureModels.Where(x => x.Temperature == temperature);
            return models.Select(model => new TemperatureModel(model.Id, temperature, model.DateTime)).ToList();
        }
    }
}