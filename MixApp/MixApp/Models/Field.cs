using System;
using SQLite;

namespace MixApp.Models
{
    //[Table("Fields")]
    public class Field
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
    }
}
