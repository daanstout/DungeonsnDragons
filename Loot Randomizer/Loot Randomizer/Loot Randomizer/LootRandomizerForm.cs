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
                //LootTablesComboBox.Items.Add(match.ToString().Substring(1));
                //lootTableList.Add(match.ToString().Substring(1));
            }

            foreach(LootTable t in lootTableList) {
                LootTablesComboBox.Items.Add(t);
            }

            //LootTablesComboBox.Items.

            //foreach(string str in lootTableList) {
            //    Console.WriteLine(str);
            //}
        }

        public void addEmptyLoot() {

        }

        private void generateLootButton_Click(object sender, EventArgs e) {
            //Console.WriteLine("GENERATIN RANDOM DROPS!");
            List<lootInheritanceClass> obtainedLoot = new List<lootInheritanceClass>();
            Random rnd;
            table = (LootTable)LootTablesComboBox.SelectedItem;
            //table = xmlLoader.importLootTable(LootTablesComboBox.SelectedItem.ToString());
            foreach(Loot l in table.lootList) {
                rnd = new Random();
                int hit = rnd.Next(1, l.lootDropChance + 1);
                if(hit == 1) {
                    obtainedLoot.Add(l);
                    //Console.WriteLine("Random number: " + hit + "\t" + l);
                    //Console.WriteLine();
                }
            }
            foreach(LootFamily f in table.lootFamilyList) {
                rnd = new Random();
                int hit = rnd.Next(1, f.lootDropChance + 1);
                //Console.WriteLine("Hit: " + hit + ", DropChance " + f.lootDropChance);
                if(hit == 1) {
                    obtainedLoot.Add(f);
                    //Console.WriteLine("Random number: " + hit + "\n" + f);
                    //Console.WriteLine();
                    //Console.WriteLine();
                }
            }
        }
    }
}
