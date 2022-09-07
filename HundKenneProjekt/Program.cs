using System;

namespace HundKenneProjekt
{
    class Program
    {

        static void Main(string[] args)
        {
            DogDBManager DBman = new DogDBManager();
            List<Dog> testList = DBman.GetDogsFromDatabase();
            DogListDisplayer testDisplayer = new DogListDisplayer();
            testDisplayer.DisplayDogList(testList);

            Console.ReadLine();
        }
    }
}