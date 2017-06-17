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
        public bool advantage { get; set; }

        public AbilityScore(string name, int score, List<SubAbilityScore> subAbilities, bool advantage) {
            this.name = name;
            this.score = score;
            this.subAbilities = subAbilities;
            this.advantage = advantage;
        }

        public override string ToString() {
            return score.ToString();
        }
    }
}
