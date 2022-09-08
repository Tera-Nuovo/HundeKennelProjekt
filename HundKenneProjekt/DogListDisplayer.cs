using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Net.Http.Headers;
using System.Collections.Generic;


namespace HundKenneProjekt
{
	public class DogListDisplayer
	{
        public void DisplayDogList(List<AbstractDog> DBDogList)
		{
			
			foreach (AbstractDog Dog in DBDogList)
			{
                Console.Write("Navn: " + Dog.Name + " || ");
                Console.Write("ID: " + Dog.ID + " || ");
                Console.Write("Køn: " + Dog.Sex + " || ");
                Console.Write("HD: " + Dog.Hips + " || ");
                Console.Write("HD Index: " + Dog.HDIndex + " ||  ");
                Console.Write("Ryg Grad: " + Dog.BackInfo + " | | ");
                Console.Write("Hjerte Grad: " + Dog.HeartInfo + "\n\n");

            }

 
        }
	}
}
