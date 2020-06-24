using System;
using SQLite;

namespace MixApp.Models
{
    public class Applicator
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
