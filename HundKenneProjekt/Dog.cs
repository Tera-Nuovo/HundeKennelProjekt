using System;
using System.Collections.Generic;
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
    public class Dog : AbstractDog   
    {
        public override string Name { get; set; }
        public override string ID { get; set; }
        public override string Sex { get; set; }
        public override string Hips { get; set; }
        public override string HDIndex { get; set; }
        public override string BackInfo { get; set; }
        public override string HeartInfo { get; set; }
    }
}
