using System;
namespace Pets
{
    public abstract class Pet
    {
        public string Name { get; set; }
        public virtual void MakeHappyNoise()
        {
            Console.WriteLine("caw caw!");
        }
    }
}

