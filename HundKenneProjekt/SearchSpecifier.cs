using System;
using System.Collections.Generic;



namespace HundKenneProjekt
{
    public class SearchSpecifier
    {
        public double Max { get; set; }
        public double Min { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }

        static public SearchSpecifier RequestDogList()
        {
            SearchSpecifier SS = new SearchSpecifier();
            SS.GetMax();
            SS.GetMin();
            SS.GetCategori();
            SS.GetPriority();

            return SS;
        }

        private void GetMax()
        {
            string input;
            double max;
            Console.WriteLine("Specificer max værdi");
            input = Console.ReadLine();

            while (!double.TryParse(input, out max))
            {
                Console.WriteLine("Kunne ikke læses. Prøv igen.");
                Console.WriteLine("Specificer max værdi");
                input = Console.ReadLine();
            }

            this.Max = max;
        }

        private void GetMin()
        {
            string input;
            double min;

            Console.WriteLine("Specificer minimum værdi");
            input = Console.ReadLine();

            while (!double.TryParse(input, out min))
            {
                Console.WriteLine("Kunne ikke læses. Prøv igen.");
                Console.WriteLine("Specificer minimum værdi");
                input = Console.ReadLine();
            }

            this.Min = min;
        }

        private void GetPriority()
        {
   
            string input;

            Console.WriteLine("Specificer prioritet:");
            Console.WriteLine("Højeste værdi først =\"hf\"");
            Console.WriteLine("Laveste værdi først =\"lf\"");
            
            input = Console.ReadLine();

            while (input != "hf" && input != "lf")
            {
                Console.WriteLine("Kunne ikke læses. Prøv igen.");
                Console.WriteLine("Specificer prioritet:");
                Console.WriteLine("Højeste værdi først =\"hf\"");
                Console.WriteLine("Laveste værdi først =\"lf\"");
                input = Console.ReadLine();
            }

            this.Priority = input;
        }

        private void GetCategori()
        {
            string input;

            Console.WriteLine("Specificer sorteingskategori:");
            Console.WriteLine("HD-Index = \"hd-index\"");

            input = Console.ReadLine();

            while (!DoesStringMatchOptions(input))
            {
                Console.WriteLine("Kunne ikke læses. Prøv igen.");
                Console.WriteLine("Specificer sorteingskategori:");
                Console.WriteLine("HD-Index = \"hd-index\"");
                input = Console.ReadLine();
            }

            this.Category = input;
        }

        private bool DoesStringMatchOptions(string input)
        {
            switch (input)
            {
                case "hd-index":
                    return true;
                default:
                    return false;
            }
        }
    }
}

