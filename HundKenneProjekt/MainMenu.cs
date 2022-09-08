using System;
using System.Linq.Expressions;

namespace HundKenneProjekt
{
    static public class MainMenu
    {
        static private String state = "start";

        static public void RunMainMenu()
        {
            while (state != "quit")
            {
                SetState(Console.ReadLine());

                switch (state)
                {
                    case "search":
                        SearchSpecifier.RequestDogList();
                        break;
                    case "quit":
                        state = "quit";
                        break;
                    default:
                        state = "wrong input";
                        break;
                }

            }
        }

        static private void ReactToState()
        {
            switch (state)
            {
                case "search":
                    //SearchSpecifier.RequestDogList();
                    break;
                case "quit":
                    state = "quit";
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
    }
}

