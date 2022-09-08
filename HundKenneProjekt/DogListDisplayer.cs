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

namespace HundKenneProjekt
{
	public class DogListDisplayer
	{

		public void DisplayDogList(List<Dog> doglist)
		{
			List<Dog> displaydoglist = new List<Dog>();
			string curdir = Directory.GetCurrentDirectory();
			string filename = @"..\..\..\Database\HundeData.csv";

			string[] linesInFile = File.ReadAllLines(filename);
			string[] DogDetails = new string[0]; 

			for (int i = 0; i < linesInFile.Length; i++)
			{
				string currentDog1 = linesInFile[i];
				DogDetails = currentDog1.Split(',');

				foreach (var p in DogDetails)
				{
					Dog dog = new Dog();
					{
						dog.ID = p;
					};
					displaydoglist.Add(dog);
				}

			}

            /*DogDBManager DBman = new DogDBManager();
            List<Dog> testList = DBman.GetDogsFromDatabase();
            DogListDisplayer testDisplayer = new DogListDisplayer();
            testDisplayer.DisplayDogList(testList);

            Console.ReadLine();
			*/

            Console.WriteLine(displaydoglist);

			Console.ReadKey();
		}
	}
}
