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
        public IDogDBManager dbManager = new DogDBManager();
        
        

        public DogListManager()
        {
            
        }

        ///Seach Funktion Via Index
        public void searchSpecifier(string Max, string Min)
        {
            double.TryParse(Min, out double minIndex);
            double.TryParse(Max, out double MaxIndex);
            ///Seach dog Via Index
            foreach(Dog dog in HdIndexSortedList(dbManager.GetDogsFromDatabase()))
            {
                double.TryParse(dog.HDIndex, out double DogsIndex);
                if(DogsIndex >= minIndex && DogsIndex <= MaxIndex)
                {
                    Console.WriteLine(dog.Name + "     " + dog.HDIndex);
                }
            }

        }

        //Sort Dog and make ready
        public List<AbstractDog> HdIndexSortedList(List<AbstractDog> dogs)
        {
            List<AbstractDog> IndexSortedList = dogs.OrderBy(o=>o.HDIndex).Reverse().ToList();
            return IndexSortedList;
        }
    }
}

