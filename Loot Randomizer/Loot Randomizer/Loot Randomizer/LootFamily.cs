using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Randomizer {
    public class LootFamily : lootInheritanceClass {
        public List<Loot> lootFamily { get; }
        public int lootDropChance { get; set; }
        public int lootMinimumDropAmount { get; set; }
        public int lootMaximumDropAmount { get; set; }
        public int lootDropAmount { get; set; }

        public LootFamily() {
            lootFamily = new List<Loot>();
        }

        public void addLoot(Loot loot) {
            lootFamily.Add(loot);
        }

        public override string ToString() {
            string str = "";
            if (lootMinimumDropAmount > 0) {
                str += ", LootminimumDropAmount: " + lootMinimumDropAmount;
            }
            if (lootMaximumDropAmount > 0) {
                str += ", lootMaximumDropAmount: " + lootMaximumDropAmount;
            }
            if (lootDropAmount > 0) {
                str += ", lootDropAmount: " + lootDropAmount;
            }
            foreach(Loot loot in lootFamily) {
                str += "\n\t" + loot;
            }
            return str;
        }
    }
}
