using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MurderMystery.Models.Acts
{
    public class ActClue
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Reveal { get; set; }

        public enum ClueSolutionTypes
        {
            Puzzle,
            Discussion,
            Document,
            Image,
            Cipher,
            Wordplay,
            Anagram,
            Riddle,
            Call
        }
        public ClueSolutionTypes ClueSolutionType { get; set; }

        public enum ClueInvolvementTypes
        {
            Revenge,
            Greed,
            Hatred,
            Jealousy,
            Anger,
            Fear,
            Insanity,
            Power,
            Passion,
            Betrayal,
            Desperation,
            Impulse,
            Provocation,
            Ideology,
            Psychopathy
        }
        public ClueInvolvementTypes ClueInvolvementType { get; set; }
    }
}
