using System;
namespace HundKenneProjekt
{
    static public class MainMenu
    {
        static private String state = "start";

        static public void RunMainMenu()
        {
            while(state != "quit")
            {
                string input = Console.ReadLine();

                if(state == "search")
                {
                    //SearchSpecifier.RequestDogList();
                }
            }
        }
    }
}

