using System;

namespace OopTask
{
	public class Lion : Animal
	{
		public string Roar()
		{
			return "wrrrrr";
		}

		public override void Print(string animal)
		{
			base.Print(animal);
			Console.WriteLine("Roar: " + this.Roar());
		}
	}
}