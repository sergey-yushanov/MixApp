using System;
using System.Collections.Generic;
using System.Text;

namespace MixApp.Models
{
    public enum MenuItemType
    {
        Mixtures,
        Assignments,
        Recipes,
        Components,
        Applicators,
        Objects,
        Transports,
        Crops,
        ProcessingTypes,
        AgriculturalYears,
        Fields
    }

    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}
