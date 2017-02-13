using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class SubAbilityScore {
        public string name { get; }
        public int score { get; set; }

        public SubAbilityScore(string N, int S) {
            name = N;
            score = S;
        }
    }
}
