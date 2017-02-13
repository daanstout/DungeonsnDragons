using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    class MediumArmor : Armor{
        public MediumArmor(string armorMaterial, int baseArmor, bool stealthDisadvantage, int weigth) : base(armorMaterial, baseArmor, stealthDisadvantage, weigth) { }
    }
}
