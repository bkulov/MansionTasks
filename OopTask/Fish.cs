using System;

namespace OopTask
{
	public class Fish : Animal
	{
		public virtual string Swim()
		{
			return "splah";
		}
	
		public override void Print(string animal)
		{
			base.Print(animal);
			Console.WriteLine("Swim: " + this.Swim());
		}
	}
}