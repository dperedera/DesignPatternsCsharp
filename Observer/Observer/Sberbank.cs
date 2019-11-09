using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	class Sberbank : IObserver
	{
		private ExchangeRates _rates;

		public void Update(ExchangeRates rates)
		{
			UpdateRates(rates);
			WriteRates();
		}

		/// <summary>
		/// У Сбербанка свои заморочки с курсами, своя формула на каждую валютную пару
		/// </summary>
		/// <param name="rates"></param>
		private void UpdateRates(ExchangeRates rates)
		{
			_rates.EurRub = rates.EurRub * 1.12;
			_rates.GbpRub = rates.GbpRub * 1.7 -3;
			_rates.UsdRub = rates.UsdRub + 2;
		}

		private void WriteRates()
		{
			Console.WriteLine("Sberbank.");
			Console.WriteLine("Здравствуйте, уважаемые клиенты. Сообщаем вам новые курсы валют.");
			Console.WriteLine($"Доллар США: {Math.Round(_rates.UsdRub, 2)} руб.");
			Console.WriteLine($"Евро: {Math.Round(_rates.EurRub, 2)} руб.");
			Console.WriteLine($"Фунт стерлингов: {Math.Round(_rates.GbpRub, 2)} руб.");
			Console.WriteLine("Всего хорошего!");
			Console.WriteLine();
		}
	}
}
