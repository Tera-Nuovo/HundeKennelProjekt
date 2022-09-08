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
        public void DisplayDogList(List<AbstractDog> DBDogList)
		{
			
			foreach (AbstractDog Dog in DBDogList)
			{
                Console.WriteLine(Dog.Name);
                Console.WriteLine(Dog.ID);
                Console.WriteLine(Dog.Sex);
                Console.WriteLine(Dog.HDIndex);
                Console.WriteLine(Dog.BackInfo);
                Console.WriteLine(Dog.HeartInfo + "\n");

            }

 
        }
	}
}
