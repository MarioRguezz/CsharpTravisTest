
using System;

namespace Pruebascsharp
{
	public class MainClass
	{
		//fibonacci code
		public int Fibonacci(int n)
		{
			if (n == 0 || n == 1)
			{
				return n;
			}
			else
			{
				return Fibonacci(n - 1) + Fibonacci(n - 2);
			}
		}

		//main method
		public static void Main(string[] args)
		{
			MainClass fib = new MainClass();
			Console.WriteLine(fib.Fibonacci(20));
		}
	}
}