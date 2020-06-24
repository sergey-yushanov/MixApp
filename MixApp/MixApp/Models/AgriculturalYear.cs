using System;
using SQLite;

namespace MixApp.Models
{
    public class AgriculturalYear
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
