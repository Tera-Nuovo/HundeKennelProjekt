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
    public class DogDBManager : IDogDBManager
    {
        public List<AbstractDog> GetDogsFromDatabase()
        {
            using (var streamReader = new StreamReader(@"..\..\..\Database\HundeData.csv"))
            {
                var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Delimiter = ";"
                };
                using (var csvReader = new CsvReader(streamReader, csvConfig))
                {
                    List<DBDog> DBDogList = csvReader.GetRecords<DBDog>().ToList();
                    return ConvertFromDBDogListToAbstractDogList(DBDogList);
                }
            }
        }

        private List<AbstractDog> ConvertFromDBDogListToAbstractDogList(List<DBDog> DBDogList)
        {
            List<AbstractDog> AbstractDogList = new List<AbstractDog>();
            foreach(DBDog Dog in DBDogList)
            {
                AbstractDogList.Add(Dog);
            }

            return AbstractDogList;
        }
    }
}
