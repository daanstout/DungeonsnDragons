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

        public lootRandomizerForm() {
            InitializeComponent();

            lootRandomizerFormInit();
        }

        public void lootRandomizerFormInit() {
            xmlLoader = new XMLLoader();
            
            getLootTables();
            xmlLoader.importLootTable("Crate");
        }

        public void getLootTables() {
            lootTableList = new List<string>();
            
            string[] lootTables = Directory.GetFiles(Referal.lootTablesMapName, Referal.XMLAnotation);
            Regex regex = new Regex(@"(\/[a-z 1-9 A-Z]*)");
            foreach(string str in lootTables) {
                Match match = regex.Match(str);
                lootTableList.Add(match.ToString().Substring(1));
            }

            //foreach(string str in lootTableList) {
            //    Console.WriteLine(str);
            //}
        }

        public void addEmptyLoot() {

        }
    }
}
