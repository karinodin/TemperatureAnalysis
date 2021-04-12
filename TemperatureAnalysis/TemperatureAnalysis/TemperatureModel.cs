using System;

namespace TemperatureAnalysis
{
    public class TemperatureModel
    {
        public int Id;
        public double Temperature;
        public DateTime DateTime;

        public TemperatureModel(int id, double temperature, DateTime dateTime)
        {
            Id = id;
            Temperature = temperature;
            DateTime = dateTime;
        }
    }
}