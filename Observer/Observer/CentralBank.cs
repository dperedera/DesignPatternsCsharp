using System;
using System.Collections.Generic;

namespace Observer
{
	internal class CentralBank : IObservable
	{
		private readonly List<IObserver> _observers;
		private ExchangeRates _rates;


		public CentralBank()
		{
			_observers = new List<IObserver>();
			_rates = new ExchangeRates
			{
				UsdRub = 60,
				EurRub = 70,
				GbpRub = 100
			};

		}

		public void RegisterObserver(IObserver observer)
		{
			if (!_observers.Contains(observer))
				_observers.Add(observer);
		}

		public void RemoveObserver(IObserver observer)
		{
			if (_observers.Contains(observer))
				_observers.Remove(observer);
		}

		public void Notify()
		{
			foreach (var observer in _observers)
			{
				observer.Update(_rates);
			}
		}

		public void ChangeRates()
		{
			var rnd = new Random().NextDouble();
			Console.WriteLine($"rnd: {rnd}");
			var rndCoefficient = rnd + 1;
			_rates.UsdRub *= rndCoefficient;
			_rates.EurRub *= rndCoefficient;
			_rates.GbpRub *= rndCoefficient;
			Notify();
		}
	}
}