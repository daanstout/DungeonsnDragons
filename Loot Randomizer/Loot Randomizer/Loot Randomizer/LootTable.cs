using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loot_Randomizer {
    public class LootTable {
        public string lootTableName { get; set; }
        public List<Loot> lootList { get; }
        public List<LootFamily> lootFamilyList { get; }

        public LootTable(string name) {
            lootTableName = name;

            lootList = new List<Loot>();
            lootFamilyList = new List<LootFamily>();
        }

        public LootTable() {
            lootList = new List<Loot>();
            lootFamilyList = new List<LootFamily>();
        }

        public void addLoost(Loot loot) {
            lootList.Add(loot);
        }

        public void addLootFamilyList(LootFamily lootFamily) {
            lootFamilyList.Add(lootFamily);
        }

        public override string ToString() {
            return lootTableName;
        }

        public void printTable() {
            Console.WriteLine("Printing LootTable: " + lootTableName);
            Console.WriteLine("Loot:");
            foreach (Loot l in lootList) {
                Console.WriteLine(l);
            }
            Console.WriteLine("LootFamilies:");
            foreach (LootFamily l in lootFamilyList) {
                Console.WriteLine(l);
            }
        }
    }
}
