using System;

namespace Props
{

	// We can avhieve the same with a Property

	// even simpler with auto implemented properties

	public class Person2
	{
		public DateTime Birthdate { get; private set; } // internally creates a private field and getters and setters 
														// when private is read only
		public int Age
		{
			get //  we include some logic cause years are based on birthdate
			{
				var timeSpan = DateTime.Today - Birthdate;
				var years = timeSpan.Days / 360;
				return years;
			}
		}

		public Person2(DateTime birthdate)
		{
			Birthdate = birthdate;
		}

	}

}
