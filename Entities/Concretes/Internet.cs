using System;
using Entities.Abstractions;

namespace Entities.Concretes
{
    public class Internet: IObserver
    {
        public void Update()
        {
            Console.WriteLine("Internet updated.");
        }
    }
}