using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    class HeavyArmor : Armor {
        public int minimumStrength { get; }

        public HeavyArmor(string name, int weigth, int worth, int baseArmor, bool stealthDisadvantage, int minimumStrength) : base(name, weigth, worth, baseArmor, stealthDisadvantage) {
            this.minimumStrength = minimumStrength;
        }
    }
}
