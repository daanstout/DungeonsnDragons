using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterSheet {
    public class Inventory {
        private readonly Character owner;

        public Inventory(Character owner) {
            this.owner = owner;
        }
    }
}
