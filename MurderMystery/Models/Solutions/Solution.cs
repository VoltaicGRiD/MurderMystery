using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurderMystery.Models.Solutions
{
    public class Solution
    {
        public int Id { get; set; }
        public bool Modified { get; set; }
        public SolutionDetails Details { get; set; }
    }
}
