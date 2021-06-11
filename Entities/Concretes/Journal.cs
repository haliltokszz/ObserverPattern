using System;
using Entities.Abstractions;

namespace Entities.Concretes
{
    public class Journal: IObserver
    {
        public void Update()
        {
            Console.WriteLine("Journal updated.");
        }
    }
}