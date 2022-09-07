using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace HundKenneProjekt
{
	public class DogListDisplayer
	{
		public void DisplayDogList()
		{
			List<double> displaydoglist = new List<double>()
			{ 1, 2, 3, 4, 5, 6};
				

			Console.WriteLine(displaydoglist);

			Console.ReadKey();
		}
	}
}
