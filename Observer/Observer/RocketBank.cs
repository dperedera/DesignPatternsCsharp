using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
	class RocketBank :IObserver
	{
		private ExchangeRates _rates;
		private const double Coefficient = 1.1;

		public void Update(ExchangeRates rates)
		{
			UpdateRates(rates);
			WriteRates();
		}

		/// <summary>
		/// РокетБанк не заморачивается. И все курсы валют умножает на коэффициент.
		/// </summary>
		/// <param name="rates"></param>
		private void UpdateRates(ExchangeRates rates)
		{
			_rates.EurRub = rates.EurRub * Coefficient;
			_rates.GbpRub = rates.GbpRub * Coefficient;
			_rates.UsdRub = rates.UsdRub * Coefficient;
		}

		private void WriteRates()
		{
			Console.WriteLine("Rocketbank.");
			Console.WriteLine("Йо йо йо! Всем привет от Рокетбанка! \n" +
			                  "Сейчас мы сообщим вам новые курсы валют! ");
			Console.WriteLine($"Бакс: {Math.Round(_rates.UsdRub, 2)} руб.");
			Console.WriteLine($"Евро: {Math.Round(_rates.EurRub, 2)} руб.");
			Console.WriteLine($"Фунт: {Math.Round(_rates.GbpRub, 2)} руб.");
			Console.WriteLine("До новых встреч с рокетом! Йо!");
			Console.WriteLine();
		}
	}
}
