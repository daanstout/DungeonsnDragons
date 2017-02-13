using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class Armor {
        //public string armorType { get; }
        public string armorMaterial { get; }
        public int baseArmor { get; }
        //public bool allowModifier { get; }
        //public int maxModifier { get; }
        //public int minimumStrength { get; }
        public bool stealthDisadvantage { get; }
        public int weight { get; set; }

        public Armor(string armorMaterial, int baseArmor, bool stealthDisadvantage, int weight) {
            this.armorMaterial = armorMaterial;
            this.baseArmor = baseArmor;
            this.stealthDisadvantage = stealthDisadvantage;
            this.weight = weight;
        }
    }
}
