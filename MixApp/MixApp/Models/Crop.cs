using System;
using SQLite;

namespace MixApp.Models
{
    public class Crop
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
