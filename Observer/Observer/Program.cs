using System;

namespace Observer
{/// <summary>
/// Реализуем паттерн проектирования под названием Наблюдатель, или Observer.
/// Допустим, есть центральный банк, ГРКЦ. Каждый день он публикует курсы валют.
/// (А может быть, он будет еще и ключевую ставку менять?)
/// Каждый банк ревностно следит за тем, чтобы случайно не потерять деньги.
/// Поэтому они сразу настраивают новые курсы валют, зависимые от курса центробанка.
/// Банки будут наблюдателями, центробанк - наблюдаемый. 
/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var centralBank = new CentralBank();

			var rocket = new RocketBank();
			var sber = new Sberbank();

			centralBank.RegisterObserver(rocket);
			centralBank.RegisterObserver(sber);

			centralBank.Notify();
			centralBank.ChangeRates();
			centralBank.ChangeRates();
			centralBank.ChangeRates();
			centralBank.ChangeRates();

			Console.ReadKey();
		}
	}
}
