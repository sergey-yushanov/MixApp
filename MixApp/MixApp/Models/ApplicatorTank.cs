using System;
using SQLite;

namespace MixApp.Models
{
    public class ApplicatorTank
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Volume { get; set; }
        public Applicator Applicator { get; set; }
    }
}
