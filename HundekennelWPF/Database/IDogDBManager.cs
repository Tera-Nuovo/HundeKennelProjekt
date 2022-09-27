using System;
using System.Collections.Generic;


namespace HundKenneProjekt
{
    public interface IDogDBManager
    {
        public List<AbstractDog> GetDogsFromDatabase();
    }
}

