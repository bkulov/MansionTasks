using System;

namespace OopTask
{
	public class FlyingAnimal : Animal
	{
		public string Fly()
		{
			return "whoohooo";
		}

		public override void Print(string animal)
		{
			base.Print(animal);
			Console.WriteLine("Fly: " + this.Fly());
		}
	}
}