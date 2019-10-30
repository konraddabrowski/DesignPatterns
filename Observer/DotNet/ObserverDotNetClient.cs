namespace Arcaim.DesignPatterns.Observer.DotNet
{
    public static class ObserverDotNetClient
    {
        public static void Run()
        {
            var station = new StationWheader();

            var condition = new CurrentCondition();
            var forecast = new Forecast();

            System.Console.WriteLine("First readings data...");
            station.SetReading(26.6f, 54, 1012.1f);

            condition.Subscribe(station);
            System.Console.WriteLine("Second readings data...");
            station.SetReading(16.6f, 64, 912.2f);

            forecast.Subscribe(station);
            System.Console.WriteLine("Third readings data...");
            station.SetReading(11.6f, 154, 612.1f);

            condition.Unsubscribe();
            System.Console.WriteLine("Fourth readings data...");
            station.SetReading(30.6f, 74, 1112.1f);
        }
    }
}