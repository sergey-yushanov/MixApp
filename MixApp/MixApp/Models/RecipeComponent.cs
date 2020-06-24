using System;
using SQLite;

namespace MixApp.Models
{
    public class RecipeComponent
    {
        //[PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public Recipe Recipe { get; set; }
        public Component Component { get; set; }
        public int Order { get; set; }
        public float Volume { get; set; }
    }
}
