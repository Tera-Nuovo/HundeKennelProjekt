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
        public override string Name { get; set; }
        [Name("ID")]
        public override string ID { get; set; }
        [Name("sex")]
        public override string Sex { get; set; }
        [Name("HD")]
        public override string Hips { get; set; }
        [Name("HDindex")]
        public override string HDIndex { get; set; }
        [Name("SP")]
        public override string BackInfo { get; set; }
        [Name("HZ")]
        public override string HeartInfo { get; set; }
        
    }
}