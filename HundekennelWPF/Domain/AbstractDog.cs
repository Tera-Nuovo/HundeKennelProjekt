using System;

namespace HundKenneProjekt
{
    public abstract class AbstractDog
    {
        public DogDBManager dogDBman = new DogDBManager();
        public abstract string Name { get; set; }
        public abstract string ID { get; set; }
        public abstract string Sex { get; set; }
        public abstract string Hips { get; set; }
        public abstract string HDIndex { get; set; }
        public abstract string BackInfo { get; set; }
        public abstract string HeartInfo { get; set; }
        public abstract string DadStambog { get; set; }
        public abstract string MomStambog { get; set; }
        public abstract string Stambog { get; set; }

        /*public AbstractDog Dad()
        {
            foreach(AbstractDog dog in dogDBman.GetDogsFromDatabase())
            {
                if(dog.Stambog == this.DadStambog)
                {
                    return dog;
                }
            }
            return null;
        }

        public AbstractDog Mom()
        {
            foreach (AbstractDog dog in dogDBman.GetDogsFromDatabase())
            {
                if (dog.Stambog == this.MomStambog)
                {
                    return dog;
                }
            }
            return null;
        }*/

        public override string ToString()
        {
            return "ID: " + ID + " || " + "Navn: " + Name + " || " + "Køn: " + Sex + " || " + "HD: " + Hips + " || " +"\n" + "HD Index: " + HDIndex + " ||  " + "Ryg Grad: " + BackInfo + " | | " + "Hjerte Grad: " + HeartInfo + "\n";
        }
    }
}

