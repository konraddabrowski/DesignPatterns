namespace Arcaim.DesignPatterns.Observer.Simple.Observers
{
    public interface IObserver
    {
        void Update(float tempetature, float humidity, float pressure);
    }
}