// Wzorzec Obserwator definiuje pomiędzy obiektami relację
// jeden-do-wielu w taki sposób, że kiedy wybrany obiekt
// zmienia swój stan, to wszystkie jego obiekty zależne
// zostają o tym poinformowane i automatycznie zaktualizowane.

using Arcaim.DesignPatterns.Observer.Observables.Simple;
using Arcaim.DesignPatterns.Observer.Simple.Observers;

namespace Arcaim.DesignPatterns.Observer.Simple
{
    public static class ObserverSimpleClient
    {
        public static void Run()
        {
            var data = new WeatherData();

            var conditions = new CurrentConditions(data);
            var statistics = new Statistics(data);
            var forecast = new Forecast(data);

            data.SetReading(26.6f, 54, 1012.1f);
            data.SetReading(16.6f, 64, 912.2f);
        }
    }
}