using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MurderMystery.Models.Acts.Recipes;

namespace MurderMystery.Models.Acts
{
    public class Act
    {
        public int Index { get; set; }
        public int Target { get; set; }
        public ActRecipe Recipe { get; set; }
        public ActClue Clue { get; set; }
        public string Solution { get; set; }
    }
}
