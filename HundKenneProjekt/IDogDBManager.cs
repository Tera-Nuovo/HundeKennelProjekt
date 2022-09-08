using System;
namespace HundKenneProjekt
{
    public interface IDogDBManager
    {
        public List<AbstractDog> GetDogsFromDatabase();
    }
}

