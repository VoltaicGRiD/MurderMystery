using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurderMystery.Models.Roles
{
    public class Initiator : Player
    {
        public DateTime Event { get; set; }
        public string Weapon { get; set; }
        public string Location { get; set; }
    }
}
