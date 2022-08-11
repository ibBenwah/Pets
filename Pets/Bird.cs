using System;
namespace Pets
{
	public class Bird : Pet
	{
        public string Color { get; set; }

        public Bird()
		{
			Color = "green";
		}
	}
}

