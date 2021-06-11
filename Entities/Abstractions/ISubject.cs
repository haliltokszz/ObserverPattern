using System.Collections.Generic;

namespace Entities.Abstractions
{
    public interface ISubject
    {
        void RemoveObserver(IObserver observer);
        void RegisterObserver(IObserver observer);
        void NotifyObserver();
    }
}