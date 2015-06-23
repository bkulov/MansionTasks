using System;

namespace OopTask
{
	public class Dolphin : Fish
	{
		public string Jump()
		{
			return "yyaayy";
		}

		public override void Print(string animal)
		{
			base.Print(animal);
			Console.WriteLine("Jump: " + this.Jump());
		}
	}
}