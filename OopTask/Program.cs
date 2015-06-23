using System;

namespace OopTask
{
	class Program
	{
		static void Main(string[] args)
		{
			var dolphin = AnimalFactory.CreateDolphin(24);
			dolphin.Print("Dolphin");
			Console.WriteLine();

			var lion = AnimalFactory.CreateLion(10);
			lion.Print("Lion");
			Console.WriteLine();

			var eagle = AnimalFactory.CreateFlyingAnimal(21);
			eagle.Print("Eagle");
			Console.WriteLine();

			var bee = AnimalFactory.CreateFlyingAnimal(1);
			bee.Print("Bee");
			Console.WriteLine();

			var shark = AnimalFactory.CreateShark(15);
			shark.Print("Shark");
			Console.WriteLine();

			Console.ReadLine();
		}
	}
}
