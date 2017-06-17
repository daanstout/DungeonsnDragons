using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    class LightArmor : Armor {
        public LightArmor(string name, int weigth, int worth, int baseArmor, bool stealthDisadvantage) : base(name, weigth, worth, baseArmor, stealthDisadvantage) { }
    }
}
