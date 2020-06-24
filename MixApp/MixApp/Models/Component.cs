using System;
using SQLite;

namespace MixApp.Models
{
    public enum ComponentType
    {
        Liquid,
        Dry
    }

    public class Component
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public ComponentType ComponentType { get; set; }
        public float Density { get; set; }
        public string Packing { get; set; }
    }
}
