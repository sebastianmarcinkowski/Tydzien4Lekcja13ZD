using System;

namespace Tydzien4Lekcja13ZD
{
	internal class Program
	{
		static void Main(string[] args)
		{
			try
			{
				while (true)
				{
					Description();

					var number = GetInt();
					Console.Clear();

					var game = new FizzBuzz(number);
					Console.WriteLine($"Teraz moja kolej... {game.Play()}!");

					Console.Write("Aby zagrać jeszcze raz wpisz 'TAK' i zatwierdź enterem, w przeciwnym wypadku wystarczy wcisnąć samo enter: ");
					if (!(Console.ReadLine().ToUpper() == "TAK"))
						break;
					Console.Clear();
				}
			}
			catch (Exception)
			{
				Console.Clear();
				Console.WriteLine("Wystąpił nieoczekiwany błąd, program zostanie zamknięty!");
			}
			finally
			{
				Console.Write("Aby zakończyć program naciśnij dowolny klawisz...");
				Console.ReadKey();
			}
		}
		static void Description()
		{
			Console.WriteLine("Zagrajmy w FizzBuzz!");
			Console.WriteLine("---------------------------------------------------------------------------------");
			Console.WriteLine("Jeśli podana przez Ciebie liczba będzie podzielna przez 3 wyświetlę Fizz.");
			Console.WriteLine("Jeśli podana przez Ciebie liczba będzie podzielna przez 5 wyświetlę Buzz.");
			Console.WriteLine("Jeśli podana przez Ciebie liczba będzie podzielna przez 3 i 5 wyświetlę FizzBuzz!");
			Console.WriteLine("W innym przypadku wyświetlę liczbę którą wprowadziłeś.");
			Console.WriteLine("---------------------------------------------------------------------------------");
		}
		static int GetInt()
		{
			var number = 0;

			Console.Write("Wprowadź liczbę: ");

			while (true)
			{
				if (int.TryParse(Console.ReadLine(), out number))
					break;

				Console.Clear();
				Console.WriteLine("Podana wartość jest nieprawidłowa, spróbuj jeszcze raz!");
				Console.Write("Wprowadź liczbę: ");
			}

			return number;
		}
	}
}
