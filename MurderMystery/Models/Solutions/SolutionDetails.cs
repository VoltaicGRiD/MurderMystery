using MurderMystery.Models.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurderMystery.Models.Solutions
{
    public class SolutionDetails
    {
        public Initiator Initiator { get; set; }
        public List<Accomplice> Accomplices { get; set; }
        public string Weapon { get; set; }
        public string Method { get; set; }
        public string Location { get; set; }
        public DateTime Event { get; set; }

        [Flags]
        public enum Requirements
        {
            Weapon,
            Method,
            Location,
            Date
        }
    }
}
