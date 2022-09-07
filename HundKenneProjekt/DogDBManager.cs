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
    public class DogDBManager
    {
        public List<Dog> GetDogsFromDatabase()
        {
            using (var streamReader = new StreamReader(@"\bin\Debug\HundeData.csv"))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";"
                };
                using (var csvReader = new CsvReader(streamReader, csvConfig))
                {
                    List<Dog> DogList = csvReader.GetRecords<Dog>().ToList();
                    return DogList;
                }
            }
        }
    }
}
