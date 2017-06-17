using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class Armor : Item {
        public string armorMaterial { get; }
        public int baseArmor { get; }
        public bool stealthDisadvantage { get; }

        public Armor(string name, int weigth, int worth, int baseArmor, bool stealthDisadvantage) : base(name, weigth, worth){
            this.baseArmor = baseArmor;
            this.stealthDisadvantage = stealthDisadvantage;
        }
    }
}
