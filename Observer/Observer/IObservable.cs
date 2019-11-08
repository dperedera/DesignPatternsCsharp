﻿namespace Observer
{
	internal interface IObservable
	{
		void RegisterObserver(IObserver observer);
		void RemoveObserver(IObserver observer);
		void Notify();
	}
}