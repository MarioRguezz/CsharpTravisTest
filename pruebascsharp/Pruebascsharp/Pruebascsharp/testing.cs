using Xunit;
namespace Pruebascsharp
{
	public class Tests
	{
		[Fact]
		public void Get_5th_number()
		{
			var generator = new MainClass();

			Assert.Equal(generator.Fibonacci(5), 5);
		}

		[Fact]
		public void Get_6th_number()
		{
			var generator = new MainClass();

			Assert.Equal(generator.Fibonacci(6), 8);
		}
		public static void Main(string[] args)
		{
			Tests fib = new Tests();
			fib.Get_5th_number();
			fib.Get_6th_number();

		}
	}