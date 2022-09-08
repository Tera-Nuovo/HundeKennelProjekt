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
    public class DBDog : AbstractDog
    {
        [Name("navn")]
        public string Name { get; set; }
        [Name("ID")]
        public string ID { get; set; }
        [Name("sex")]
        public string Sex { get; set; }
        [Name("HD")]
        public string Hips { get; set; }
        [Name("HDindex")]
        public string HDIndex { get; set; }
        [Name("SP")]
        public string backInfo { get; set; }
        [Name("HZ")]
        public string HeartInfo { get; set; }

    }
}