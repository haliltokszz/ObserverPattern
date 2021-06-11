using System;
using Entities.Abstractions;
using Entities.Concretes;

namespace PresentationLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            IObserver journal = new Journal();
            IObserver internet = new Internet();
            Credit credit = new Credit();
            credit.RegisterObserver(journal);
            credit.RegisterObserver(internet);
            credit.SetInterestRate(1.15f);
            credit.NotifyObserver();
            credit.RemoveObserver(internet);
            credit.SetInterestRate(1.35f);
            credit.NotifyObserver();
            credit.RemoveObserver(journal);
            credit.SetInterestRate(1.0f);
            credit.NotifyObserver();
        }
    }
}