using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    class HeavyArmor : Armor {
        public int minimumStrength { get; }

        public HeavyArmor(string armorMaterial, int baseArmor, bool stealthDisadvantage, int weigth, int minimumStrength) : base(armorMaterial, baseArmor, stealthDisadvantage, weigth) {
            this.minimumStrength = minimumStrength;
        }
    }
}
