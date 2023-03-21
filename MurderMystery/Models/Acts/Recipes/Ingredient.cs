using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurderMystery.Models.Acts.Recipes
{
    public class Ingredient
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
        public string Size { get; set; }
        public int? Temperature { get; set; }
    }
}
