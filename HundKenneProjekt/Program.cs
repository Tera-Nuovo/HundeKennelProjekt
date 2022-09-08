using System;

namespace HundKenneProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();

            mainMenu.RunMainMenu();

            DogDBManager DBman = new DogDBManager();
            List<AbstractDog> testList = DBman.GetDogsFromDatabase();
            DogListDisplayer testDisplayer = new DogListDisplayer();
            testDisplayer.DisplayDogList(testList);

            Console.ReadLine();
        }
    }
}