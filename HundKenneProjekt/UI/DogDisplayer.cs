using System;
namespace HundKenneProjekt
{
    public class DogDisplayer
    {
        public DogDisplayer()
        {
        }
        static public void DisplayDog(AbstractDog Dog)
        {
            Console.WriteLine("Navn: " + Dog.Name );
            Console.WriteLine("ID: " + Dog.ID);
            Console.WriteLine("Køn: " + Dog.Sex);
            Console.WriteLine("HD: " + Dog.Hips);
            Console.WriteLine("HD Index: " + Dog.HDIndex);
            Console.WriteLine("Ryg Grad: " + Dog.BackInfo );
            Console.WriteLine("Hjerte Grad: " + Dog.HeartInfo + "\n\n");
        }
    }
}

