using Arcaim.DesignPatterns.Observer.Simple.Observers;

namespace Arcaim.DesignPatterns.Observer.Simple.Observables
{
    public interface IObservable
    {
        void Register(IObserver observer);
        void Remove(IObserver observer);
        void InformObservers();
    }
}