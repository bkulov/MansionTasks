using System;
using System.Linq;

namespace OopTask
{
	public static class AnimalFactory
	{
		public static Dolphin CreateDolphin(int age)
		{
			return new Dolphin()
			{
				Age = age
			};
		}

		public static Lion CreateLion(int age)
		{
			return new Lion()
			{
				Age = age
			};
		}

		public static FlyingAnimal CreateFlyingAnimal(int age)
		{
			return new FlyingAnimal()
			{
				Age = age
			};
		}

		public static Fish CreateShark(int age)
		{
			return new Fish()
			{
				Age = age
			};
		}
	}
}
