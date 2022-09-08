using System;
namespace HundKenneProjekt
{
    static public class SearchSpecifier
    {
        //Ikke færdig!
        static public void RequestDogList()
        {

        }

        static private int GetMax()
        {
            string input;
            int max;
            Console.WriteLine("Specificer max værdi");
            input = Console.ReadLine();

            if (int.TryParse(input, out max))
            {
                return max;
            } else
            {
                return -1;
            }


            
        }

        static private int GetMin()
        {
            string input;
            int min;

            Console.WriteLine("Specificer minimum værdi");
            input = Console.ReadLine();

            if (int.TryParse(input, out min))
            {
                return min;
            }
            else
            {
                return -1;
            }
        }

        static private string GetPriority()
        {
   
            string priority;

            Console.WriteLine("Specificer om listen skal sortes med højeste værdig øverst eller laveste værdi øverst.");

            priority = Console.ReadLine();
            if(priority == "hf")
            {
                return "hf";
            } else
            {
                return "";
            }




        }

        static private string GetCategori()
        {
            string categori;

            Console.WriteLine("Specificer sorteingskategori");

            categori = Console.ReadLine();

            Console.WriteLine("Specificer om listen skal sortes med højeste værdig øverst eller laveste værdi øverst.");

            if ("hf" == "hf")
            {
                return "hf";
            }




        }
    }
}

