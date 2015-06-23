using System;

namespace OopTask
{
	public class Animal
	{
		public int Age { get; set; }

		public virtual string Sleep()
		{
			return "zzzzzz";
		}

		public virtual string Eat()
		{
			return "yummy";
		}

		public virtual void Print(string animal)
		{
			Console.WriteLine("-- {0} --", animal);
			Console.WriteLine("Age: " + this.Age);
			Console.WriteLine("Sleep: " + this.Sleep());
			Console.WriteLine("Eat: " + this.Eat());
		}
	}
}
