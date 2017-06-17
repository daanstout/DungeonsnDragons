using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    class MediumArmor : Armor {
        public MediumArmor(string name, int weigth, int worth, int baseArmor, bool stealthDisadvantage) : base(name, weigth, worth, baseArmor, stealthDisadvantage) { }
    }
}
