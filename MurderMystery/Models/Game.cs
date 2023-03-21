using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MurderMystery.Models.Acts;
using MurderMystery.Models.Roles;
using MurderMystery.Models.Solutions;

namespace MurderMystery.Models
{
    public class Game
    {
        public int Id { get; set; }
        public int ActCount { get; set; }
        public Initiator Initiator { get; set; }
        public List<Accomplice> Accomplices { get; set; }
        public List<NoRole> NoRoles { get; set; }
        public List<Act> Acts { get; set; }
        public Solution Solution { get; set; } 
    }
}
