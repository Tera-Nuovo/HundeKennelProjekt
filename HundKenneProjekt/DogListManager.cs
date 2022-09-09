using System.Linq;
using System.Text;
using System.Collections.Generic;
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
        public DogDBManager dbManager;
        public List<AbstractDog> CurentDogList = new List<AbstractDog>();

        public void RequestRemoveSort(SearchSpecifier SS)
        {
            RequestDogsFromDatabase();
            RemoveUnqualifiedDogs(SS);
            SortDogList(SS);
        }

        public DogListManager()
        {
            this.dbManager = new DogDBManager();
        }

        void RemoveUnqualifiedDogs(SearchSpecifier SS)
        {
            // her fjerne vi kun hund der ikke lever op til kriterierne.
            foreach(AbstractDog dogs in this.CurentDogList.ToList())
            {
                double.TryParse(dogs.HDIndex, out double dogsIndex);

                if(dogsIndex < SS.Min || dogsIndex > SS.Max)
                {
                    CurentDogList.Remove(dogs);
                }
            }
            
        }

        public void SortDogList(SearchSpecifier SS)
        {
            //Func<AbstractDog, double> ConvertToDouble = x =>
            //{
            //    double result;

            //    if (double.TryParse(x.HDIndex, out result))
            //    {
            //        return result;
            //    } else
            //    {
            //        return -1;
            //    }
            //};
            //sort dogs
            
            // her ændres kun på rækkefølgen af listen
            if(SS.Priority == "hf")
            {
                CurentDogList = CurentDogList.OrderBy(x => x.HDIndex).Reverse().ToList();
                //CurentDogList = CurentDogList.OrderBy(ConvertToDouble).Reverse().ToList();
            }
            else if(SS.Priority == "lf")
            {
                CurentDogList = CurentDogList.OrderBy(x => x.HDIndex).ToList();
                //CurentDogList = CurentDogList.OrderBy(ConvertToDouble).ToList();
            }
            //SS.Max det er en int 
            //SS.Min = int
            //SS.Categori = string "hd-index"
            //SS.Priority = string  "hf" or "lf"
        }

        public void RequestDogsFromDatabase()
        {
            CurentDogList = dbManager.GetDogsFromDatabase();
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

