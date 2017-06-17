using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class CharacterClass {
        public string className { get; }
        public string description { get; }
        public Referal.hitDie hitDie { get; }
        public string primaryAbility { get; }
        //public string savingThrowProficiencies { get; }
        public string savingThrowProficiencies { get; }
        public string armorAndWeaponProficiencies { get; }

        public CharacterClass(string className, string description, Referal.hitDie hitDie, string primaryAbility, string savingThrowProficiencies, string armorAndWeaponProficiencies) {
            this.className = className;
            this.description = description;
            this.hitDie = hitDie;
            this.primaryAbility = primaryAbility;
            this.savingThrowProficiencies = savingThrowProficiencies;
            this.armorAndWeaponProficiencies = armorAndWeaponProficiencies;
        }
    }
}
