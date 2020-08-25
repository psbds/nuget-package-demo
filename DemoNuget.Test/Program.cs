using DemoNuget.Library;
using System;

namespace DemoNuget.Test
{
	class Program
	{
		static void Main(string[] args)
		{
			var calculator = new Calculator();
			Console.WriteLine(calculator.Sum(1, 1));
		}
	}
}
