using System;
using System.Linq.Expressions;
using System.Collections.Generic;


namespace HundKenneProjekt
{
    public class MainMenu
    {
        private String state = "start";
        DogListManager DLMan = new DogListManager();
        DogListDisplayer DLDisplayer = new DogListDisplayer();

        public void RunMainMenu()
        {
            WriteStartText();
            while (state != "quit")
            {
                SetState(Console.ReadLine());
                ReactToState();
            }
        }

        void WriteStartText()
        {
            Console.WriteLine("Skriv search for at søge");
            Console.WriteLine("Skriv quit for at stoppe");
        }

        private void ReactToState()
        {
            switch (state)
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

        private void SetState(string input)
        {
            switch (input)
            {
                case "search":
                    state = "search";
                    break;
                case "quit":
                    state = "quit";
                    break;
                default:
                    state = "wrong input";
                    break;
            }

        }

        private void WrongInputMessage()
        {
            Console.WriteLine("Inputet kunne ikke læses. Prøv igen.");
        }

        void Search()
        {
            DLMan.RequestRemoveSort(SearchSpecifier.RequestDogList());
            DLDisplayer.DisplayDogList(DLMan.CurentDogList);

        }
    }
}

