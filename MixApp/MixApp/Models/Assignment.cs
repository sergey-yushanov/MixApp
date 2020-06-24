using System;
using SQLite;

namespace MixApp.Models
{

    public class Assignment
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Note { get; set; }
        public Recipe Recipe { get; set; }
        public Tank SourceTank { get; set; }
        public Tank DestinationTank { get; set; }
        public AgriculturalYear AgriculturalYear { get; set; }
        public Field ProcessingField { get; set; }
        public Object ProductionObject { get; set; }
        public float Volume { get; set; }
        public float VolumeRate { get; set; }
    }
}
