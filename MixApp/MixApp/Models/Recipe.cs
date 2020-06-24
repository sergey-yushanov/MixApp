using System;
using SQLite;

namespace MixApp.Models
{
    public class Recipe
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public Crop Crop { get; set; }
        public ProcessingType ProcessingType { get; set; }
        public Component CarrierComponent { get; set; }
        public string Note { get; set; }
        public float CarrierStockRate { get; set; }
        public float CarrierStockMin { get; set; }
        public string Code { get; set; }
    }
}
