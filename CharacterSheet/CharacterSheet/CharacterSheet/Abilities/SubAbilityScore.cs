using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class SubAbilityScore {
        public string name { get; }
        public bool advantage { get; set; }

        public SubAbilityScore(string name, bool advantage) {
            this.name = name;
            this.advantage = advantage; 
        }
    }
}
