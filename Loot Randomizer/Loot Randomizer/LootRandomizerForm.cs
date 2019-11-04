using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loot_Randomizer {
    public partial class lootRandomizerForm : Form {
        XMLLoader xmlLoader;
        List<LootTable> lootTableList;
        LootTable table;

        public lootRandomizerForm() {
            InitializeComponent();

            lootRandomizerFormInit();
        }

        public void lootRandomizerFormInit() {
            xmlLoader = new XMLLoader();
            
            getLootTables();

            LootTablesComboBox.SelectedIndex = 0;
        }

        public void getLootTables() {
            lootTableList = new List<LootTable>();
            
            string[] lootTables = Directory.GetFiles(Referal.lootTablesMapName, Referal.XMLAnotation);
            Regex regex = new Regex(@"(\/[a-z 1-9 A-Z]*)");
            foreach(string str in lootTables) {
                Match match = regex.Match(str);
                xmlLoader.importLootTable(match.ToString().Substring(1), ref lootTableList);
            }

            foreach(LootTable t in lootTableList) {
                LootTablesComboBox.Items.Add(t);
            }
        }

        public void addEmptyLoot() {

        }

        private void generateLootButton_Click(object sender, EventArgs e) {
            List<lootInheritanceClass> obtainedLoot = new List<lootInheritanceClass>();
            Random rnd;
            table = (LootTable)LootTablesComboBox.SelectedItem;
            foreach(Loot l in table.lootList){
                rnd = new Random();
                int hit = rnd.Next(1, l.lootDropChance + 1);
                if(hit == 1) {
                    obtainedLoot.Add(l);
                }
            }
            foreach(LootFamily f in table.lootFamilyList) {
                rnd = new Random();
                int hit = rnd.Next(1, f.lootDropChance + 1);
                if(hit == 1) {
                    obtainedLoot.Add(f);
                }
            }
            GeneratedLoot generatedLoot = new GeneratedLoot(obtainedLoot);
            generatedLoot.ShowDialog();
        }
    }
}
