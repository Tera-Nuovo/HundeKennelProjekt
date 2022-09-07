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
    public class DogListManager
    {
        public DogDBManager dbManager = new DogDBManager();
        
        public DogListManager()
        {
            
        }

        ///Seach Funktion Via Index
        /*public void searchViaIndex()
        {
            ///Seach dog Via Index
            Console.WriteLine("Type Minimum HD-Index");

            double.TryParse(Console.ReadLine(), out double hdIndexNumber);


            foreach (Dog dog in dbManager.GetDogsFromDatabase())
            {
                double.TryParse(dog.HDIndex, out double dogHDindex);
                if (hdIndexNumber <= dogHDindex)
                {
                    Console.WriteLine(dog.Name + " || " + dog.ID + "  ||  " + dog.Sex + "   ||  Dog HDIndex: " + dog.HDIndex);
                }

            }

        }*/
    }
}

