using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Randomizer {
    public class LootFamily {
        public List<Loot> lootFamily { get; }
        public int lootDropChance { get; }
        public int lootMinimumDropAmount { get; }
        public int lootMaximumDropAmount { get; }
        public int lootDropAmount { get; }

        public LootFamily() {

        }
    }
}
