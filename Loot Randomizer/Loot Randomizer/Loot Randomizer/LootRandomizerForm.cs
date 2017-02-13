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
        List<string> lootTableList;
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
            lootTableList = new List<string>();
            
            string[] lootTables = Directory.GetFiles(Referal.lootTablesMapName, Referal.XMLAnotation);
            Regex regex = new Regex(@"(\/[a-z 1-9 A-Z]*)");
            foreach(string str in lootTables) {
                Match match = regex.Match(str);
                LootTablesComboBox.Items.Add(match.ToString().Substring(1));
                //lootTableList.Add(match.ToString().Substring(1));
            }

            //LootTablesComboBox.Items.

            //foreach(string str in lootTableList) {
            //    Console.WriteLine(str);
            //}
        }

        public void addEmptyLoot() {

        }

        private void generateLootButton_Click(object sender, EventArgs e) {
            Console.WriteLine("GENERATIN RANDOM DROPS!");
            Random rnd;
            table = xmlLoader.importLootTable(LootTablesComboBox.SelectedItem.ToString());
            foreach(Loot l in table.lootList) {
                rnd = new Random();
                int hit = rnd.Next(1, l.lootDropChance + 1);
                if(hit == 1) {
                    Console.WriteLine("Random number: " + hit + "\t" + l);
                    Console.WriteLine();
                }
            }
        }
    }
}
