using System;
namespace Pets
{
    public class Panther:Pet
    {
        public string Noise { get; set; }

        public Panther()
        {
            Noise = "RAWWWRRRR";
        }
        public override  void MakeHappyNoise()
        {
            Console.WriteLine("RAWWWRRRR");
        }
    }
}

