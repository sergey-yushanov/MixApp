using System;
using SQLite;

namespace MixApp.Models
{
    public class TransportTank
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Volume { get; set; }
        public Transport Transport { get; set; }
    }
}
