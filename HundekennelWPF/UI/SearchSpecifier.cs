using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;

namespace HundKenneProjekt
{
    public class SearchSpecifier
    {
        public double Max { get; set; }
        public double Min { get; set; }
        public string Category { get; set; }
        public string Priority { get; set; }
        public string Gender { get; set; }

        static public SearchSpecifier GetSearchSpecifier(string hdMax, string hdMin,string gender, string priority)
        {
            SearchSpecifier SS = new SearchSpecifier();
            SS.GetMax(hdMax);
            SS.GetMin(hdMin);
            SS.GetGender(gender);
            //SS.GetCategori();
            SS.GetPriority(priority);

            return SS;
        }

        private void GetGender(string gender)
        {;
            this.Gender = gender[0].ToString();
        }

        private void GetMax(string hdMax)
        {
            //double.TryParse(hdMax, out double max);
            if(double.TryParse(hdMax, out double max))
            {
                 this.Max = max;
            }

            
        }

        private void GetMin(string hdMin)
        {
            //double.TryParse(hdMax, out double max);
            if (double.TryParse(hdMin, out double min))
            {
                this.Min = min;
            }
        }

        private void GetPriority(string priority)
        {
   
            this.Priority = priority;
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

