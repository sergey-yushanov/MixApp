using System;
using SQLite;

namespace MixApp.Models
{
    public enum TankType
    {
        Object,
        Transport,
        Applicator
    }

    public class Tank
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public TankType TankType { get; set; }
        public Object Object { get; set; }
        public Transport Transport { get; set; }
        public Applicator Applicator { get; set; }
    }
}
