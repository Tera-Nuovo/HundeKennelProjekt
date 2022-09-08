using System;
namespace HundKenneProjekt
{
    public interface IDogDBManager : DogDBManager
    {
        public List<AbstractDog> GetDogsFromDatabase();
    }
}

