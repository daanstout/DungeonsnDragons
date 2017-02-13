using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class AbilityScore {
        public List<SubAbilityScore> subAbilities { get; }

        public string name { get; }
        public int score { get; set; }

        public AbilityScore(string N, int SC, List<SubAbilityScore> SA) {
            name = N;
            score = SC;
            subAbilities = SA;
        }

        public override string ToString() {
            return score.ToString();
        }
    }
}
