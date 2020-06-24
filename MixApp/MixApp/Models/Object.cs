using System;
using SQLite;

namespace MixApp.Models
{
    public enum ObjectType
    {
        Storage,
        Shipment
    }

    public class Object
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public ObjectType Type { get; set; }
        public string Address { get; set; }
        public string Code { get; set; }
    }
}
