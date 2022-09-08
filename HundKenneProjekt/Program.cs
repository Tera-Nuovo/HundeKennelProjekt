using System;
using System.Collections.Generic;

namespace HundKenneProjekt
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();

            mainMenu.RunMainMenu();
            Console.ReadLine();
        }
    }
}