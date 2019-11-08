using System.Collections.Generic;

namespace Observer
{
	internal class Bank : IObservable
	{
		private readonly List<IObserver> _observers;

		public Bank()
		{
			_observers = new List<IObserver>();
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
				observer.Update("hallalah!");
			}
		}
	}
}