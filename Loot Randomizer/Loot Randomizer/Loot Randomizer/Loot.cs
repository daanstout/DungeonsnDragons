using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loot_Randomizer {
    public class Loot {
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

        public Loot() {

        }

        public override string ToString() {
            return lootName + ", DropChance: " + lootDropChance + ", lootMinimumDropAmount: " + lootMinimumDropAmount + ", lootMaximumDropAmount: " + lootMaximumDropAmount + ", lootDropAmount: " + lootDropAmount;
        }
    }
}
