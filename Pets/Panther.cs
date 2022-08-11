using System;
namespace Pets
{
    abstract class Panther:Pet
    {

        public Panther()
        {
            
        }
        public override virtual void MakeHappyNoise()
        {
            Console.WriteLine("RAWWWRRRR");
        }
    }
}

