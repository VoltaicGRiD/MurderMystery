using Java.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MurderMystery.Models.Acts;
using MurderMystery.Models.Roles;

namespace MurderMystery.Generators
{
    public class ActGenerator
    {
        public Act CurrentAct { get; private set; }
        private List<Player> Players = new List<Player>();
        public List<Player> GetPlayers() { return Players; }
        public ActClue CurrentClue { get; private set; }

        public ActGenerator()
        {
            
        }

        public ActGenerator ModifyAct()
        {
            return this;
        }

        public ActGenerator ModifyInitiator()
        {
            return this;
        }

        public ActGenerator ModifyAccomplices()
        {
            return this;
        }

        public ActGenerator ModifyNoRole()
        {
            return this;
        }


        public Initiator GetInitiator()
        {
            return Players.Where(p => p.GetType() == typeof(Initiator)).FirstOrDefault() as Initiator;
        }

        public List<Accomplice> GetAccomplices()
        {
            return Players.Where(p => p.GetType() == typeof(Accomplice)) as List<Accomplice>;
        }
    }
}
