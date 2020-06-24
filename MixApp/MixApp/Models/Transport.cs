using System;
using SQLite;

namespace MixApp.Models
{
    public class Transport
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
