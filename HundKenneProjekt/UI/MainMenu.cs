using System;
using System.Linq.Expressions;
using System.Collections.Generic;


namespace HundKenneProjekt
{
    public class MainMenu
    {
        private string currentInput = "start";

        DogListManager DLMan = new DogListManager();
        DogListDisplayer DLDisplayer = new DogListDisplayer();

        public void RunMainMenu()
        {
            WriteStartText();
            currentInput = Console.ReadLine();

            while (currentInput != "quit")
            {
                ReactToState();
                currentInput = Console.ReadLine();
            }
        }

        void WriteStartText()
        {
            Console.WriteLine("Skriv search for at søge");
            Console.WriteLine("Skriv quit for at stoppe");
        }

        private void ReactToState()
        {
            int numberInput;
            if (int.TryParse(currentInput,out numberInput))
            {
                DLMan.FindDog(currentInput);
                DogDisplayer.DisplayDog(DLMan.CurrentDog);
            } else
            {
                switch (currentInput)
                {
                    case "search":
                        Search();
                        break;
                    case "quit":
                        break;
                    default:
                        WrongInputMessage();
                        break;
                }
            }
        }

        private void WrongInputMessage()
        {
            Console.WriteLine("Inputet kunne ikke læses. Prøv igen.");
        }

        void Search()
        {
            DLMan.RequestRemoveSort(SearchSpecifier.GetSearchSpecifier());
            DLDisplayer.DisplayDogList(DLMan.CurentDogList);
            currentInput = "list displayed";
        }
    }
}

