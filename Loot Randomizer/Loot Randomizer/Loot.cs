using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loot_Randomizer {
    public class Loot : lootInheritanceClass {
        public string lootName { get; set; }
        public int lootDropChance { get; set; }
        public int lootMinimumDropAmount { get; set; }
        public int lootMaximumDropAmount { get; set; }
        public int lootDropAmount { get; set; }

        public Loot(string name) {
            if (!name.Equals("")) {
                lootName = name;
            } else {
                DialogResult result = MessageBox.Show("Name is empty, Please make sure the name is correctly filled in", "Empty Name Error", MessageBoxButtons.OK);
            }
        }

        public Loot(string name, int dropChance, int minimumDropAmount, int maximumDropAmount, int dropAmount) {
            lootName = name;
            lootDropChance = dropChance;
            lootMinimumDropAmount = minimumDropAmount;
            lootMaximumDropAmount = maximumDropAmount;
            lootDropAmount = dropAmount;
        }

        public Loot() { }

        public bool getLootDrop(Random rnd) {
            double random = rnd.NextDouble();
            return random * 100 < lootDropChance;
        }

        public override string ToString() {
            string str = lootName + ", DropChance: " + lootDropChance;
            if (lootMinimumDropAmount > 0) {
                str += ", LootminimumDropAmount: " + lootMinimumDropAmount;
            }
            if (lootMaximumDropAmount > 0) {
                str += ", lootMaximumDropAmount: " + lootMaximumDropAmount;
            }
            if (lootDropAmount > 0) {
                str += ", lootDropAmount: " + lootDropAmount;
            }
            return str;
        }
    }
}
