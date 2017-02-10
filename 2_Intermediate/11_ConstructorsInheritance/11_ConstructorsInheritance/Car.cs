using System;

namespace _ConstructorsInheritance
{

	// During Object Istantiation:
	// 1. Base class constructors always executed first
	// 2. Base class construcors are not inherited

	public class Car : Vehicle
	{
		public Car()
		{
			Console.WriteLine("Car is being initialized");
		}

		readonly string _registrationNumber;

		public Car(string RegistrationNumber)
			: base ( string RegistrationNumber)
		{
			this._registrationNumber = RegistrationNumber;
		}
	}
}
