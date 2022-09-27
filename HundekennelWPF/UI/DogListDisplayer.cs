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
        string Output;
        public string DisplayDogList(List<AbstractDog> DBDogList)
		{
            Output = "";
            foreach (AbstractDog Dog in DBDogList)
            {
                Output = Output + ((DBDogList.IndexOf(Dog) + 1) + ": ");
                Output = Output + ("ID: " + Dog.ID + " || ");
                Output = Output + ("Navn: " + Dog.Name + " || ");
                Output = Output + ("Køn: " + Dog.Sex + " || ");
                Output = Output + ("HD: " + Dog.Hips + " || ");
                Output = Output + ("HD Index: " + Dog.HDIndex + " ||  ");
                Output = Output + ("Ryg Grad: " + Dog.BackInfo + " | | ");
                Output = Output + ("Hjerte Grad: " + Dog.HeartInfo + "\n\n");

            }
            return Output;
        }
	}
}
