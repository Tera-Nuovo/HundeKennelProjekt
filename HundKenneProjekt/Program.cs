using System;

namespace HundKenneProjekt
{
    class Program
    {

        static void Main(string[] args)
        {
            DogDBManager DBman = new DogDBManager();
            List<Dog> testList = DBman.GetDogsFromDatabase();

            Console.ReadLine();
        }
    }
}