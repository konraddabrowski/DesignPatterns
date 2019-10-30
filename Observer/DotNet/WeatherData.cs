namespace Arcaim.DesignPatterns.Observer.DotNet
{
    public class WeatherData
    {
        public float Humidity { get; private set; }
        public float Pressure { get; private set; }
        public float Tempetature { get; private set; }

        public void SetReading(float tempetature, float humidity, float pressure)
        {
            Humidity = humidity;
            Pressure = pressure;
            Tempetature = tempetature;
        }
    }
}