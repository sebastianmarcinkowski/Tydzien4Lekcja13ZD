namespace Tydzien4Lekcja13ZD
{
	internal class FizzBuzz
	{
		private int _number;
		public FizzBuzz(int number)
		{
			_number = number;
		}
		public string Play()
		{
			if ((_number % 3 == 0) && (_number % 5 == 0)) return "FizzBuzz";
			if (_number % 3 == 0) return "Fizz";
			if (_number % 5 == 0) return "Buzz";
			return _number.ToString();
		}
	}
}
