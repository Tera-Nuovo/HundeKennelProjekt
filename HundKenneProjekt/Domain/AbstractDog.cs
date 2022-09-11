using System;

namespace HundKenneProjekt
{
    public abstract class AbstractDog
    {
        public abstract string Name { get; set; }
        public abstract string ID { get; set; }
        public abstract string Sex { get; set; }
        public abstract string Hips { get; set; }
        public abstract string HDIndex { get; set; }
        public abstract string BackInfo { get; set; }
        public abstract string HeartInfo { get; set; }
    }
}

