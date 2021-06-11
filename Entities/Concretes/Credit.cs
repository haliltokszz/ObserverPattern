using System;
using System.Collections.Generic;
using Entities.Abstractions;

namespace Entities.Concretes
{
    public class Credit: ISubject
    {
        private float _interestRate;
        private List<IObserver> Observers { get; set; } = new List<IObserver>();

        public void SetInterestRate(float interestRate)
        {
            _interestRate = interestRate;
        }
        public void RemoveObserver(IObserver observer)
        {
            Observers.Remove(observer);
        }

        public void RegisterObserver(IObserver observer)
        {
            Observers.Add(observer);
        }

        public void NotifyObserver()
        {
            if(Observers.Count == 0) Console.WriteLine("There are no observers.");
            else
            {
                foreach (var observer in Observers)
                {
                    Console.Write("Notify Observer: "); 
                    observer.Update();
                }
            }
        }
    }
}