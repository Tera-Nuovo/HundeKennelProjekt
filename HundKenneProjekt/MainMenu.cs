using System;
using System.Linq.Expressions;

namespace HundKenneProjekt
{
    public class MainMenu
    {
        static private String state = "start";
        DogListManager DLMan = new DogListManager();
        DogListDisplayer DLDisplayer = new DogListDisplayer();

        public void RunMainMenu()
        {
            while (state != "quit")
            {
                SetState(Console.ReadLine());
                ReactToState();

            }
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

        static private void SetState(string input)
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

        static private void WrongInputMessage()
        {
            Console.WriteLine("Inputet kunne ikke læses. Prøv igen.");
        }

        void Search()
        {
            DLMan.RequestRemoveSort(SearchSpecifier.RequestDogList());
            //DLDisplayer.DisplayDogList(DLMan.CurentDogList);

        }
    }
}

